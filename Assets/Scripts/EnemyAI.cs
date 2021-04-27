using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 1f;
    public float timerSpeed; //Este valor define los segundos del temporizador

    private float stunTimer = 4f; //Temporizador del STUN

    private float timerSpeedAttack = 0.8f; //Temporizador del ataque (ataca a los 0.8 segundos de estar en rango)

    public float attackDelay = 1;

    private float lastAttackTime;

    private float elapsed;

    private float elapsedF;

    private float elapsedStun;

    private Animator animator;

    SpriteRenderer sprite;

    public int hp;

    private bool stunned;

    public int damage;

    public int range;

   /* public Transform moveSpot;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;*/

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        elapsed += Time.deltaTime;
        stunned = false;
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (hp <= 0)
        {
            kill();
        }
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        if (!stunned)
        {
            float separation = Vector3.Distance(this.transform.position, player.transform.position);
            elapsed += Time.deltaTime;
            
            if (elapsed >= timerSpeed)
            {
                elapsed = 0f;


                Debug.Log("Range to player = " + separation);
                
                if (separation <= range)
                {
                    Debug.Log("The enemy sees the player");
                    chasePlayer(movement);
                }

                /*else if (separation > range)
                {

                    Debug.Log("The enemy is patrolling");
                    Patrol();
                }*/
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

            if (separation > 1)
            {
                animator.ResetTrigger("isAttacking");
                animator.SetTrigger("isWalking");
            }
        }

        else
        {
            elapsedStun += Time.deltaTime;
            if (elapsedStun >= stunTimer)
            {
                elapsedStun = 0f;
                unStun();
            }


        }

    }

    void chasePlayer(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
           
    }

    private void kill()
    {

        Destroy(gameObject);
    }

    private void getStunned()
    {
        stunned = true;
        sprite.color = new Color(0, 0, 1, 1);
        hp -= 20;
        return;

    }

    private void unStun()
    {
        stunned = false;
        sprite.color = new Color(1, 1, 1, 1);
        return;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Earthquake"))
        {

            getStunned();
        }

    }

    void attackPlayer()
    {
        if (Time.time > lastAttackTime + attackDelay)
        {
            animator.SetTrigger("isAttacking");
            Debug.Log("Player Taking Damage");
            player.SendMessage("TakeDamage", damage);
            lastAttackTime = Time.time;

        }
    }

    void Patrol()
    {
        //moveSpot.position = new Vector2(Random.Range(minX,maxX), Random.Range(minY,maxY));
        //transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, moveSpeed * Time.deltaTime);
    }
}
