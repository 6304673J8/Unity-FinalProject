using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class SusanaControlled : MonoBehaviour
{
    PlayerInputs controls;

    [SerializeField] private float lungeDistance;

    //Collision Check
    [SerializeField]
    private Tilemap floorTilemap;
    [SerializeField]
    private Tilemap collisionTilemap;
    [SerializeField]
    private Tilemap damagingTilemap;
    [SerializeField]
    private Tilemap healingTilemap;
    [SerializeField] float speed;
    Vector2 move;

    bool facingRight = true;
    bool isMoving;

    public bool canMove = false;

    Rigidbody2D rb;


    //new
    // shows rounded position = tile position

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        controls = new PlayerInputs();

        controls.Susana.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Susana.Move.canceled += ctx => move = Vector2.zero;
    }

    private void OnEnable()
    {
        controls.Susana.Enable();
    }
    private void OnDisable()
    {
        controls.Susana.Disable();
    }

    /*private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if (move.x != 0)
        {
            if (facingRight == false && move.x > 0)
            {

                Flip();

            }
            else if (facingRight == true && move.x < 0)
            {
                Flip();
            }
            if (CanMove(move) && canMove == true)
            {
                Debug.Log("Moving");
                move = new Vector2Int(Mathf.FloorToInt(move.x), Mathf.FloorToInt(move.y));
                transform.position += (Vector3)move;
                rb.velocity = new Vector2(move.x * speed, rb.velocity.y);
            }
        }
        else
        {
            //Debug.Log("PROTECT");
            isMoving = false;
        }
    }*/

    void FixedUpdate()
    {
        Vector3Int gridPos = floorTilemap.WorldToCell(transform.position + (Vector3)move);

        if (move.x != 0)
        {
            if (facingRight == false && move.x > 0)
            {

                Flip();

            }
            else if (facingRight == true && move.x < 0)
            {
                Flip();
            }
            if (floorTilemap.HasTile(gridPos) || !collisionTilemap.HasTile(gridPos))
            {
                Debug.Log("Moving");
                move = new Vector2Int(Mathf.FloorToInt(move.x), Mathf.FloorToInt(move.y));
                //rb.velocity = new Vector2(move.x * speed * Time.fixedDeltaTime, rb.velocity.y);
                transform.position += (Vector3)move;
            }
        }
        else
        {
            //Debug.Log("PROTECT");
            isMoving = false;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    /*public void Earthquake()
    {
        Debug.Log("BROOOM");
    }

    public void Lunge()
    {
        Debug.Log("Lunging");
        //transform.position += (Vector3)axis * 2;
    }

    private void CheckFlip()
    {
        if (facingRight == false && axis.x > 0)
        {

            Flip();

        }
        else if (facingRight == true && axis.x < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void SetAxis(Vector2 _axis)
    {
        print(axis);
        axis = _axis;
    }
    public bool IsMoving()
    {
        return isMoving;
    }*/
    /*
     *
     *https://www.youtube.com/watch?v=oBvWOHHbzJ0&list=PLzDRvYVwl53vXmpctKrMQTxA3cQwGcAk2&index=5
     private void Move(Vector2 dir)
    {
        bool isIdle = dir.x == 0 && dir.y == 0;
        if (isIdle)
        {
            Debug.Log("Animación IDLE");
        }
        else
        {
            //si falla quitar normalized
            Vector3 movementDir = new Vector3(dir.x, dir.y);

            bool canMove = CanMove(movementDir, speed * Time.deltaTime);
            if (TestMove(movementDir,speed * Time.deltaTime))
            {
                Debug.Log("SIIIIIII" + dir);
                //transform.position += movementDir;
                //dir = new Vector2Int(Mathf.FloorToInt(dir.x), Mathf.FloorToInt(dir.y));
                //transform.position += (Vector3)dir;
            }
            else
            {
                Debug.Log("NOOOOOOOO" + dir);
                //transform.position += lastMoveDir;
            }
        }
    }
    private bool CanMove(Vector3 dir, float distance)
    {
        return Physics2D.Raycast(transform.position, dir, distance).collider == null;
    }

    private bool TestMove(Vector3 baseMoveDir, float distance)
    {
        Vector3 moveDir = baseMoveDir;
        bool canMove = CanMove(moveDir, distance);
        if (!canMove)
        {
            //cannot move diagonal
            moveDir = new Vector3(baseMoveDir.x, 0f);
            canMove = moveDir.x != 0f && CanMove(moveDir, distance);
            if (!canMove)
            {
                //cannot move horizontal
                moveDir = new Vector3(0, baseMoveDir.y);
                canMove = moveDir.y != 0f && CanMove(moveDir, distance);
            }
        }
        if (canMove)
        {
            lastMoveDir = moveDir;
            transform.position += moveDir * distance;
            return true;
        }
        else
        {
            return false;
        }
    }
     */
}
