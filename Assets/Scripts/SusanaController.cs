using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class SusanaController : MonoBehaviour
{
    [SerializeField]
    private Tilemap floorTilemap;
    [SerializeField]
    private Tilemap collisionTilemap;

    private PlayerInput controller;

    private enum States { NONE, ATTACK, DEFENSE };
    //Movimiento Susana
    public Transform movePivot;

    //HP SUSANA
    public HealthBar healthBar;
    public int hp;
    private int originalHp;

    private bool facingRight = true;

    private Rigidbody2D rb;
    //new
    [SerializeField] private float speed;
    // shows rounded position = tile position
    public Vector3Int movementToInt;
    public Vector3 pos;
    Vector2 movement;

    private void Awake()
    {
        controller = new PlayerInput();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        controller.Enable();
    }

    private void OnDisable()
    {
        controller.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        originalHp = hp;
        healthBar.SetMaxHealth(originalHp);

        controller.Floor.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        controller.Floor.Lunge.performed += ctx => Lunge();
        controller.Floor.Defense.started += ctx => Defense();
        controller.Floor.Defense.canceled += ctx => Defense();


        //controller.Floor.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }
    //First Attempt
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 hitPosition = Vector3.zero;
        Vector3Int gridPosition = breakableTilemap.WorldToCell(transform.position);

        if (breakableTilemap != null && breakableTilemap == collision.gameObject)
        {
            Debug.Log("ok");
            breakableTilemap.SetTile(gridPosition, null);
        }
    }*/
    //new

    private void FixedUpdate()
    {
        movement = controller.Floor.Move.ReadValue<Vector2>();

        if (facingRight == false && movement.x > 0) {

            Flip();

        } else if (facingRight == true && movement.x < 0)
        {
            Flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check if the tag of the trigger collided with is Exit.
        if (other.tag == "Breakable")
        {
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Enemy")
        {
            Debug.Log("AAAAAAAAAAAAA");
            other.gameObject.SetActive(false);

            //other.gameObject.transform.position += this.transform.position;
        }
    }
    private void Move(Vector2 dir)
    {
        if (CanMove(dir))
        {
            dir = new Vector2Int(Mathf.FloorToInt(dir.x), Mathf.FloorToInt(dir.y));
            transform.position += (Vector3)dir;
        }
    }

    private void Defense()
    {
        Debug.Log("PROTECT");
        if (hp < 300)
        {
            hp += hp * 10;
            Debug.Log("hp");
            Debug.Log(hp);
        }
        if (hp > 1001)
            hp = originalHp;
    }

    public void Lunge()
    {
        Debug.Log("Topetazo!");
        movement = controller.Floor.Move.ReadValue<Vector2>();
        if (CanLunge(movement))
            transform.position += (Vector3)movement * 2;
    }

    private bool CanLunge(Vector2 lungeToNext)
    {
        Vector3Int gridPos = floorTilemap.WorldToCell(transform.position + (Vector3)movement);
        Vector3Int lungeGridPos = floorTilemap.WorldToCell(transform.position + (Vector3)movement * 2);
        if (!floorTilemap.HasTile(gridPos) || collisionTilemap.HasTile(gridPos) ||
            !floorTilemap.HasTile(lungeGridPos) || collisionTilemap.HasTile(lungeGridPos))
        {
            return false;
        }
        return true;
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

    public void TakeDamage(int damage)
    {
        hp -= damage;
        healthBar.SetHealth(hp);
        if (hp <= 0)
        {
            Debug.Log("RIP");
            Destroy(gameObject);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
