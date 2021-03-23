using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Enemy : MonoBehaviour
{
    private float timerSpeed = 2f; //Este valor define los segundos del temporizador

    public float attackDelay = 1;

    private float lastAttackTime;

    private float elapsed;

    private float elapsedCD;
    SpriteRenderer sprite;

    public Transform player;

    public int damage;

    Rigidbody2D rb;


    [SerializeField]
    private Tilemap floorTilemap;
    [SerializeField]
    private Tilemap collisionTilemap;
    /*[SerializeField]
    private Tilemap damagingTilemap;*/



    Vector2[] directions = { Vector2.up, Vector2.right, Vector2.down, Vector2.left };

    

    //Ver la direccion actual
    [SerializeField] Vector2 currentDir;

    //La distancia a la que va a mirar el raycast
    [SerializeField] float rayDistance;

    [SerializeField] LayerMask rayLayer;

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
        /* //Raycast
         RaycastHit2D hit2D = Physics2D.Raycast(transform.position, currentDir, rayDistance, rayLayer);
         Vector3 endpoint = currentDir * rayDistance;
         Debug.DrawLine(transform.position, transform.position + endpoint, Color.green);

         if(hit2D.collider != null)
         {
             if(hit2D.collider.gameObject.CompareTag("Wall"))
             {
                 ChangeDirection();
             }

             if (hit2D.collider.gameObject.CompareTag("Breakable"))
             {
                 ChangeDirection();
             }

             if (hit2D.collider.gameObject.CompareTag("Susana"))
             {
                 attackPlayer();

             }
         }


         */
    }



    private void FixedUpdate()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= timerSpeed)
        {
            elapsed = 0f;
            Patrol();
        }
    }

    void attackPlayer()
    {
        if (Time.time > lastAttackTime + attackDelay)
        {
            player.SendMessage("TakeDamage", damage);
            lastAttackTime = Time.time;
        }
    }

    void Patrol()
    {
        int dir = Random.Range(0,4);
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



}

