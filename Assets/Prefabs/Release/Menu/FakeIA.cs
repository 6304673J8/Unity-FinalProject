using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeIA : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 1f;
    public float timerSpeed; //Este valor define los segundos del temporizador

    private float stunTimer = 4f; //Temporizador del STUN

    private float timerSpeedAttack = 0.3f; //Temporizador del ataque (ataca a los 0.8 segundos de estar en rango)

    public float attackDelay = 0.3f;

    private float lastAttackTime;

    private float elapsed;

    private float elapsedF;

    private float elapsedStun;

    private Animator animator;

    SpriteRenderer sprite;

    public int hp;

    public int range;

    public int originalRange;

    private bool facingLeft;

    public int enemyTag;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

    }

    private void Start()
    {
        facingLeft = true;
        elapsed += Time.deltaTime;
        rb = this.GetComponent<Rigidbody2D>();
        originalRange = range;
    }

    private void Update()
    {
        Vector3 direction = player.position - transform.position;
        
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        checkPosition();
        float separation = Vector3.Distance(this.transform.position, player.transform.position);
        elapsed += Time.deltaTime;

        if (elapsed >= timerSpeed)
        {
            elapsed = 0f;


            //Debug.Log("Range to player = " + separation);

            if (separation <= range)
            {
                animator.ResetTrigger("isIdle");
                animator.SetTrigger("isWalking");
                chasePlayer(movement);
                range = originalRange * 2;
            }

            else if (separation > range)
            {
                animator.ResetTrigger("isWalking");
                animator.SetTrigger("isIdle");
                range = originalRange;
            }
        }


        if (separation <= 1)
        {
            elapsedF += Time.deltaTime;
            if (elapsedF >= timerSpeedAttack)
            {
                elapsedF = 0;
                attackPlayer();
            }




        }

        if (separation <= 0.7)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }

        if (separation > 0.7)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        if (separation > 1)
        {
            animator.ResetTrigger("isAttacking");
            animator.SetTrigger("isWalking");

        }
    }

    void chasePlayer(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));

    }

    private void kill()
    {
        if (enemyTag == 1)
        {
            FindObjectOfType<SoundManager>().Play("OnaosDeath");
        }

        else if (enemyTag == 2)
        {
            FindObjectOfType<SoundManager>().Play("PiamondDeath");
        }
        sprite.color = new Color(1, 1, 1, 1);
        animator.ResetTrigger("isWalking");
        animator.SetTrigger("isDying");
    }

    void attackPlayer()
    {
        animator.ResetTrigger("isAttacking");
        animator.SetTrigger("isWalking");
        if (Time.time > lastAttackTime + attackDelay)
        {
            animator.ResetTrigger("isWalking");
            animator.SetTrigger("isAttacking");
            Debug.Log("Player Taking Damage");
            lastAttackTime = Time.time;

        }
    }

    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void checkPosition()
    {
        if (facingLeft && player.position.x > transform.position.x)
        {
            Flip();
        }

        if (!facingLeft && player.position.x < transform.position.x)
        {
            Flip();
        }
    }
}
