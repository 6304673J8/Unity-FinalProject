using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SusanaOmega : MonoBehaviour
{
    //HP SUSANA
    public HealthBar healthBar;
    public int hp;
    private int originalHp;

    private bool facingRight = true;
    private bool isMoving;

    private Rigidbody2D rb;
    //new
    [SerializeField] private float speed;
    // shows rounded position = tile position
    Vector2 axis;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        originalHp = hp;
        healthBar.SetMaxHealth(originalHp);
    }

    private void Update()
    {
        CheckFlip();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    public void Movement()
    {
        if (axis.x != 0)
        {
            Debug.Log("PR");
            //axis = new Vector2Int(Mathf.FloorToInt(axis.x), Mathf.FloorToInt(axis.y));
            //transform.position += (Vector3)axis;
            rb.velocity = new Vector2(axis.x * speed, rb.velocity.y);

        }
        else
        {
            Debug.Log("PROTECT");
            isMoving = false;
        }
        CheckFlip();
    }
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
    public void Defense()
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
        transform.position += (Vector3)axis * 2;
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
        axis = _axis;
    }
    public bool IsMoving()
    {
        return isMoving;
    }
}
