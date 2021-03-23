using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Enemy : MonoBehaviour
{
    private float timerSpeed = 1f; //Este valor define los segundos del temporizador

    private float stunTimer = 4f; //Temporizador del STUN

    private float timerSpeedAttack = 0.8f; 

    public float attackDelay = 1;

    private float lastAttackTime;

    private float elapsed;

    private float elapsedF;

    private float elapsedStun;


    SpriteRenderer sprite;


    private bool stunned;

    public Transform player;

    public int damage;

    public int range;

    Rigidbody2D rb;


    [SerializeField]
    private Tilemap floorTilemap;
    [SerializeField]
    private Tilemap collisionTilemap;
    [SerializeField]
    private Tilemap floorItemsTilemap;
    [SerializeField]
    private Tilemap breakablesTilemap;

    /*[SerializeField]
    private Tilemap damagingTilemap;*/



    Vector2[] directions = { Vector2.up, Vector2.right, Vector2.down, Vector2.left };


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

    }
    private void Start()
    {
        elapsed += Time.deltaTime;
        stunned = false;
    }


    private void Update()
    {
       

    }



    private void FixedUpdate()
    {
        if(!stunned)
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
                    followPlayer();
                }

                else if (separation > range)
                {
                    Debug.Log("The enemy is patrolling");
                    Patrol();
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

    void attackPlayer()
    {
        if (Time.time > lastAttackTime + attackDelay)
        {
            Debug.Log("Player Taking Damage");
            player.SendMessage("TakeDamage", damage);
            lastAttackTime = Time.time;
        }
    }

    void Patrol()
    {
        int dir = Random.Range(0, 3);
        Move(directions[dir]);
    }


    private void Move(Vector2 dir)
    {
        if (CanMove(dir))
        {
            dir = new Vector2Int(Mathf.FloorToInt(dir.x), Mathf.FloorToInt(dir.y));
            transform.position += (Vector3)dir;
            sprite.color = new Color(1, 1, 1, 1);

        }


    }

    private bool CanMove(Vector2 dir)
    {
        Vector3Int gridPos = floorTilemap.WorldToCell(transform.position + (Vector3)dir);
        if (!floorTilemap.HasTile(gridPos) || collisionTilemap.HasTile(gridPos) || floorItemsTilemap.HasTile(gridPos) || breakablesTilemap.HasTile(gridPos))
        {
            return false;
        }
        return true;
    }

    private void followPlayer()
    {
        if(player.position.x > rb.position.x + 1)
        {
            Move(directions[1]);
            return;
        }
        else if(player.position.x < rb.position.x - 1)
        {
            Move(directions[3]);
            return;
        }
        else if(player.position.y > rb.position.y + 1)
        {
            Move(directions[0]);
            return;
        }

        else if (player.position.y < rb.position.y - 1)
        {
            Move(directions[2]);
            return;
        }


    }

    private void getStunned()
    {
        stunned = true;
        sprite.color = new Color(0, 0, 1, 1);

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


}

