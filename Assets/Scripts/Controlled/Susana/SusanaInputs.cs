using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SusanaInputs : MonoBehaviour
{
    //Movement
    private Rigidbody2D susanaRb;
    Vector2 movement;
    public bool canMove = false;
    SpriteRenderer sprite;
    [SerializeField] private float lungeDistance;

    //HP
    public int hp;
    private int originalHp;

    private PlayerInput controller;
    private bool facingRight = true;

    //Collision Check
    [SerializeField]
    private Tilemap floorTilemap;
    [SerializeField]
    private Tilemap collisionTilemap;
    [SerializeField]
    private Tilemap damagingTilemap;
    [SerializeField]
    private Tilemap healingTilemap;

    //Skills
    public Transform lungePosition;
    public Abilities abilities;
    public bool defending;
    public bool lunging;
    public bool quaking;

    //Managers
    SusanaSkills skills;

    private enum State
    {
        IDLE,
        MOVING,
        ATTACK,
        HEALING
    }

    private State state;

    private void Awake()
    {
        controller = new PlayerInput();
        susanaRb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        skills = GameObject.FindGameObjectWithTag("GameController").GetComponent<SusanaSkills>();
        state = State.IDLE;
    }

    private void OnEnable()
    {
        controller.Enable();
    }

    private void OnDisable()
    {
        controller.Disable();
    }

    void Start()
    {
        controller.Floor.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        controller.Floor.Lunge.performed += ctx => Lunge();
        controller.Floor.Defense.started += ctx => Defense();
        controller.Floor.Defense.canceled += ctx => Defense();
        controller.Floor.Shaker.started += ctx => Earthquake();
        controller.Floor.Heal.performed += ctx => Heal();
    }

    private void FixedUpdate()
    {
        movement = controller.Floor.Move.ReadValue<Vector2>();

        if (facingRight == false && movement.x > 0)
        {

            Flip();

        }
        else if (facingRight == true && movement.x < 0)
        {
            Flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check if the tag of the trigger collided with is Exit.
        if (other.tag == "DamagingTile")
        {
            DamagedByTile();
        }
        else if (other.tag == "HealingTile")
        {
            HealedByTile();
        }
        else if (other.tag == "Door" && GameManager.Instance.keyNumber >= 1)
        {
            Debug.Log("Has usado una llave!");
            GameManager.Instance.keyNumber--;
            other.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "DamagingTile")
        {
            Debug.Log("Ya no hace pupa");
            sprite.color = new Color(1, 1, 1, 1);
        }
        if (collision.tag == "HealingTile")
        {
            Debug.Log("Ya no cura");
            sprite.color = new Color(1, 1, 1, 1);
        }
    }

    private void Defense()
    {
        state = State.HEALING;
        sprite.color = new Color(0, 1, 0, 1);
        if (hp < 300)
        {
            hp += hp * 10;
            Debug.Log("hp");
            Debug.Log(hp);
        }
        if (hp > 1001)
        {
            hp = originalHp;
        }
        state = State.IDLE;
    }

    public void Heal()
    {
        state = State.HEALING;
        const int healAmount = 100;

        if (GameManager.Instance.potionNumber >= 1)
        {
            Debug.Log("Has usado una poción!");
            if (hp <= (originalHp - healAmount))
            {
                skills.PotionLogic();
                hp += healAmount;
                GameManager.Instance.potionNumber--;
            }
            else
            {
                skills.PotionLogic();
                hp = originalHp;
                GameManager.Instance.potionNumber--;
            }
        }
    }

    private void Move(Vector2 dir)
    {
        state = State.MOVING;
        if (CanMove(dir) && canMove == true)
        {
            dir = new Vector2Int(Mathf.FloorToInt(dir.x), Mathf.FloorToInt(dir.y));
            transform.position += (Vector3)dir;
            sprite.color = new Color(1, 1, 1, 1);
        }
        state = State.IDLE;
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

    public void Lunge()
    {
        //animator.SetTrigger("Lunge");
        movement = controller.Floor.Move.ReadValue<Vector2>();
        if (movement == Vector2.zero)
            return;
        else if (CanLunge(movement) && abilities.lungeCooldown == false)
        {
            skills.LungeLogic();
            transform.position += (Vector3)movement * lungeDistance;
        }
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
        lunging = true;
        return true;
    }

    public void Earthquake()
    {
        //animator.SetTrigger("Earthquake");
        quaking = true;
        if (abilities.earthquakeCooldown == false)
        {
            quaking = true;
            sprite.color = new Color(0, 0, 1, 1);
            skills.EarthquakeLogic();
            Camera.main.GetComponent<CameraFollow>().shakeDuration = 0.2f;
        }
        //sprite.color = new Color(1, 1, 1, 1);
        //Camera.main.GetComponent<CameraShake>().shakeDuration = 0.2f;
        //gameHandler.GetComponent<CameraShake>().shakeDuration = 0.2f;
    }

    public void TakeDamage(int damage)
    {
        //animator.SetTrigger("Hurt");
        hp -= damage;
        if (hp <= 0)
        {
            //animator.SetTrigger("Dead");
            Debug.Log("RIP");
            Destroy(gameObject);
        }
    }

    public void DamagedByTile()
    {
        Vector3Int currentPos = damagingTilemap.WorldToCell(transform.position);
        if (damagingTilemap.HasTile(currentPos))
        {
            Debug.Log("Pupa");
            sprite.color = new Color(1, 0, 0, 1);
            Invoke("DamagedByTile", 1);
            TakeDamage(5);
        }
    }

    public void HealedByTile()
    {
        Vector3Int currentPos = healingTilemap.WorldToCell(transform.position);
        if (hp < originalHp)
        {
            if (healingTilemap.HasTile(currentPos))
            {
                Debug.Log("Cura");
                sprite.color = new Color(0, 1, 0, 1);
                Invoke("HealedByTile", 1);
                TakeDamage(-5);
            }
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
