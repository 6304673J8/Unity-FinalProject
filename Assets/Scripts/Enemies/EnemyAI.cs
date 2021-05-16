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

    private float timerSpeedAttack = 0.3f; //Temporizador del ataque (ataca a los 0.8 segundos de estar en rango)

    public float attackDelay = 0.3f;

    private float dieDelay = 1f;

    private float dying;

    private bool dyingb;

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

    public bool canBeInvisible;

    public bool canDrop;

    public int originalRange;

    public GameObject key;

    private bool facingLeft;

    public int enemyTag;

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
        dyingb = false;
        facingLeft = true;
        elapsed += Time.deltaTime;
        stunned = false;
        rb = this.GetComponent<Rigidbody2D>();
        originalRange = range;
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
                    if(canBeInvisible)
                    {
                        gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    }
                    Debug.Log("The enemy sees the player");
                    chasePlayer(movement);
                    range = originalRange * 2;
                }

                else if (separation > range)
                {
                    animator.ResetTrigger("isWalking");
                    animator.SetTrigger("isIdle");
                 if(canBeInvisible)
                    {
                        gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    }

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

            if(separation <= 0.7)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
            }

            if(separation > 0.7)
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
        if(enemyTag == 1)
        {
            FindObjectOfType<SoundManager>().Play("OnaosDeath");
        }

        else if(enemyTag == 2)
        {
            FindObjectOfType<SoundManager>().Play("PiamondDeath");
        }
        dyingb = true;
        sprite.color = new Color(1, 1, 1, 1);
        animator.ResetTrigger("isWalking");
        animator.SetTrigger("isDying");
        dying += Time.deltaTime;
        if (dying >= dieDelay)
        {
            Destroy(gameObject);
            if (canDrop)
            {
                GameObject k = Instantiate(key, transform.position, transform.rotation);
            }
        }
    }

    private void getStunned()
    {
        if(!dyingb)
        {
            stunned = true;
            sprite.color = new Color(0, 0, 1, 1);
            hp -= 20;
            return;
        }
       

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

        if(collision.CompareTag("Lunge"))
        {
            hp -= 10;
        }

    }


    /*private void OnCollisionStay2D(Collision2D collision)
    {
        if(gameObject.CompareTag("Susana"))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        rb.constraints = RigidbodyConstraints2D.None;
    }*/

   
    void attackPlayer()
    {
        animator.ResetTrigger("isAttacking");
        animator.SetTrigger("isWalking");
        if (Time.time > lastAttackTime + attackDelay)
        {
            animator.ResetTrigger("isWalking");
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

    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void checkPosition()
    {
        if(facingLeft && player.position.x > transform.position.x)
        {
            Flip();
        }

        if(!facingLeft && player.position.x < transform.position.x)
        {
            Flip();
        }
    }
}
