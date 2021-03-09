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

    //Movimiento Susana
    public float mSpeed = 5.0f; //Velocidad de movimiento de Susana
    public Transform movePivot;
    public int hp;
    Vector2 movement;

    private Rigidbody2D rb;
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        controller = new PlayerInput();    
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
        controller.Floor.Walking.performed += ctx => Move(ctx.ReadValue<Vector2>());
        movePivot.parent = null;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Move(Vector2 dir)
    {
        if (CanMove(dir))
        {
            transform.position += (Vector3)dir;
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

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            //Se muere
        }
    }
    // Update is called once per frame
    /*void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        transform.position = Vector3.MoveTowards(transform.position, movePivot.position, mSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePivot.position) <= .05f) {
            if (Mathf.Abs(movement.x) == 1f)
            {
                movePivot.position += new Vector3(movement.x * 3, 0f, 0f);
            } else if (Mathf.Abs(movement.y) == 1f)
            {
                movePivot.position += new Vector3(0, movement.y * 3, 0f);
            }
        }

    }
    void FixedUpdate()
    {
        float delta = Time.fixedDeltaTime * 1000; //Milisegundos desde el último frame

        rb.MovePosition(rb.position + movement * mSpeed * Time.fixedDeltaTime);

    }*/
}
