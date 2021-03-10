﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class SusanaController : MonoBehaviour
{
    [SerializeField]
    private Tilemap floorTilemap;
    [SerializeField]
    private Tilemap collisionTilemap;

    private bool m_Pressed;
    private PlayerInput controller;

    private enum States { NONE, ATTACK, DEFENSE };
    //Movimiento Susana
    public float mSpeed = 5.0f; //Velocidad de movimiento de Susana
    public Transform movePivot;
    public int hp;

    private Rigidbody2D rb;
    //new
    [SerializeField] private float speed;
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
        controller.Floor.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        controller.Floor.Lunge.performed += ctx => Lunge();

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

   /* private void FixedUpdate()
    {
        movement = controller.Floor.Move.ReadValue<Vector2>();
        rb.velocity = movement * speed;
    }*/

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check if the tag of the trigger collided with is Exit.
        if (other.tag == "Breakable")
        {
            other.gameObject.SetActive(false);
        }
    }
    private void Move(Vector2 dir)
    {
        if (CanMove(dir))
        {
            transform.position += (Vector3)dir;
        }
    }

    public void Lunge()
    {
        Debug.Log("Fire!");
        movement = controller.Floor.Move.ReadValue<Vector2>();
        transform.position += (Vector3)movement * 2;
    }

    /*private void Lunge()
    {
        if (CanLunge(movement))
        {
            Debug.Log("ok");
            this.transform.position += (Vector3)movement * 2;
        }
    }*/

    private bool CanLunge(Vector2 lungeToNext)
    {
        Vector3Int gridPos = floorTilemap.WorldToCell(transform.position + (Vector3)movement * 2);
        if (!floorTilemap.HasTile(gridPos) || collisionTilemap.HasTile(gridPos))
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
        Debug.Log("AU");
        if (hp <= 0)
        {
            Destroy(gameObject);
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
