using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class SusanaController : MonoBehaviour
{
    [SerializeField]
    private Tilemap floorTilemap;
    [SerializeField]
    private Tilemap collisionTilemap;
    [SerializeField]
    private Tilemap damagingTilemap;
    [SerializeField]
    private Tilemap healingTilemap;
    //[SerializeField]
    //private Tilemap NPCTilemap;

    private PlayerInput controller;

    SpriteRenderer sprite;

    //Movimiento Susana
    public Transform movePivot;

    public bool canMove = false;

    //HP SUSANA
    public HealthBar healthBar;
    public int hp;
    private int originalHp;

    private bool facingRight = true;

    //public Item item;
    [Header("Abilities")]

    GameHandler gameHandler;
    public GameObject earthquakePrefab;
    public GameObject lungePrefab;
    public GameObject potionPrefab;
    public Abilities abilities;
    public bool defending;
    public bool lunging;
    public bool quaking;

    private enum State
    {
        IDLE,
        MOVING,
        ATTACK,
        HEALING
    }

    private Rigidbody2D rb;
    //new
    [SerializeField] private float speed;
    [SerializeField] private float lungeDistance;

    // shows rounded position = tile position
    public Vector3Int movementToInt;
    public Vector3 pos;
    Vector2 movement;

    private Vector3 lastMoveDir;
    private State state;
    private void Awake()
    {
        controller = new PlayerInput();
        rb = GetComponent<Rigidbody2D>();
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
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        originalHp = hp;
        healthBar.SetMaxHealth(originalHp);

        controller.Floor.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        controller.Floor.Lunge.performed += ctx => Lunge();
        controller.Floor.Defense.started += ctx => Defense();
        controller.Floor.Defense.canceled += ctx => Defense();
        controller.Floor.Shaker.started += ctx => Earthquake();
        controller.Floor.Heal.performed += ctx => Heal();
    }
    private void Update()
    {
        switch (state)
        {
            case State.IDLE:
                Debug.Log("Anim IDLE");
                break;
            case State.ATTACK:
                //Debug.Log("Anim ATTACK");
                break;
            case State.MOVING:
                Debug.Log("Anim MOVE");
                break;
            case State.HEALING:
                Debug.Log("Healing");
                break;
        }
    }

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
            other.gameObject.SetActive(true);
            //other.gameObject.SetActive(true);
            //other.gameObject.transform.position += this.transform.position;
        }
        else if (other.tag == "DamagingTile")
        {
            DamagedByTile();
        }
        else if (other.tag == "HealingTile")
        {
            HealedByTile();
        }
        else if (other.tag == "NPC")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

        if (GameManager.Instance.potionNumber >= 1) {
            Debug.Log("Has usado una poción!");
            if (hp <= (originalHp - healAmount))
            {
                PotionLogic();
                hp += healAmount;
                GameManager.Instance.potionNumber--;
            }
            else
            {
                PotionLogic();
                hp = originalHp;
                GameManager.Instance.potionNumber--;
            }
        }
    }

    public void Lunge()
    {
        Debug.Log("Topetazo!");
        movement = controller.Floor.Move.ReadValue<Vector2>();
        if (CanLunge(movement) && abilities.lungeCooldown == false)
        {
            LungeLogic();
            transform.position += (Vector3)movement * lungeDistance;
        }
    }

    public void Earthquake()
    {
        quaking = true;
        if (abilities.earthquakeCooldown == false)
        {
            quaking = true;
            sprite.color = new Color(0, 0, 1, 1);
            EarthquakeLogic();
            Camera.main.GetComponent<CameraFollow>().shakeDuration = 0.2f;
        }
        //sprite.color = new Color(1, 1, 1, 1);
        //Camera.main.GetComponent<CameraShake>().shakeDuration = 0.2f;
        //gameHandler.GetComponent<CameraShake>().shakeDuration = 0.2f;
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

    public bool CanMove(Vector2 dir)
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

    public void EarthquakeLogic()
    {
        Vector2 pos = transform.position;

        GameObject earthquakeFX = Instantiate(earthquakePrefab, pos, transform.rotation);
    }

    public void LungeLogic()
    {
        Vector2 pos = transform.position;

        GameObject lungeFX = Instantiate(lungePrefab, pos, transform.rotation);
    }

    public void PotionLogic()
    {
        Vector2 pos = transform.position;

        GameObject potionFX = Instantiate(potionPrefab, pos, transform.rotation);
    }
}
