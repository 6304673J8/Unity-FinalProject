using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Enemy : MonoBehaviour
{
    private float timerSpeed = 1f; //Este valor define los segundos del temporizador

    private float timerSpeedAttack = 0.3f; 

    public float attackDelay = 1;

    private float lastAttackTime;

    private float elapsed;

    private float elapsedF;
    SpriteRenderer sprite;

    public Transform player;

    public int damage;

    public int range;

    Rigidbody2D rb;


    [SerializeField]
    private Tilemap floorTilemap;
    [SerializeField]
    private Tilemap collisionTilemap;
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
    }


    private void Update()
    {
       

    }



    private void FixedUpdate()
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

            else if(separation > range)
            { 
                Debug.Log("The enemy is patrolling");
                Patrol();
            }
        }


        if(separation <= 1)
        {
            elapsedF += Time.deltaTime;
            if(elapsedF >= timerSpeedAttack)
            {
                elapsedF = 0;
                attackPlayer();
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
        if (!floorTilemap.HasTile(gridPos) || collisionTilemap.HasTile(gridPos))
        {
            return false;
        }
        return true;
    }

    private void followPlayer()
    {
        if(player.position.x > rb.position.x)
        {
            Move(directions[1]);
            return;
        }
        else if(player.position.x < rb.position.x)
        {
            Move(directions[3]);
            return;
        }
        else if(player.position.y > rb.position.y)
        {
            Move(directions[0]);
            return;
        }

        else if (player.position.y < rb.position.y)
        {
            Move(directions[2]);
            return;
        }


    }
 

}

