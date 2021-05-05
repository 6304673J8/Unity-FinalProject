using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;


public class SusanaControlled : MonoBehaviour
{
    //testing 
    public bool saver;

    PlayerInputs controls;

    //Movement
    Vector2 move;
    public bool canMove = false;
    bool facingRight = true;

    //hp
    public HealthBar healthBar;

    bool isHurt;
    public int health;
    public int level;
    [SerializeField] private int maxHealth = 350;

    //inventory
    public int nPotions;
    public int nKeys;
    public int nBombs;

    [SerializeField] private float lungeDistance;

    //Animation
    Animator anim;
    Rigidbody2D rb;

    bool isMoving;

    bool hasLunged;

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

    [Header("Abilities")]

    public GameObject earthquakePrefab;
    public GameObject lungePrefab;
    public GameObject potionPrefab;
    public AbilitiesControlled abilities;
    public bool defending;
    public bool lunging;
    public bool quaking;
    
    //new animations
    private State state;
    public Animator animator;

    public bool isJumping;
    private int idleID;
    private int runID;
    private int lungeID;
    private int hurtID;


    // shows rounded position = tile position
    private enum State
    {
        IDLE,
        MOVING,
        ATTACK,
        HEALING
    }

    private void Awake()
    {
        //testing 
        saver = false;
        hasLunged = false;
        rb = GetComponent<Rigidbody2D>();
        controls = new PlayerInputs();
        health = maxHealth;

        state = State.IDLE;

        //items 
        nPotions = 0;
        nKeys = 0;
        nBombs = 0;

        #region INPUCTACTIONS
        controls.Susana.Move.performed += ctx => SendMessage(ctx.ReadValue<Vector2>());

        controls.Susana.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Susana.Move.canceled += ctx => move = Vector2.zero;

        //controls.Susana.Action.performed += ctx => Interact();

        //Test Abilities
        controls.Susana.Lunge.performed += ctx => Lunge();
        controls.Susana.Shield.started += ctx => Shield();
        controls.Susana.Shield.canceled += ctx => Shield();
        controls.Susana.Earthquake.started += ctx => Earthquake();
    }
    private void OnEnable()
    {
        controls.Susana.Enable();
    }
    private void OnDisable()
    {
        controls.Susana.Disable();
    }

    void SendMessage(Vector2 coordinates)
    {
        Debug.Log("Thumb-stick coordinates" + coordinates);
    }
    #endregion

    private void Start()
    {
        healthBar.SetMaxHealth(health);
        animator = GetComponent<Animator>();
        //lungeID = Animator.StringToHash("Lunge");
        hurtID = Animator.StringToHash("Hurt");
        runID = Animator.StringToHash("Movement");
    }

    public void UpdateHealth(int mod)
    {
        //animator.SetTrigger("Hurt");
        isHurt = true;
        health -= mod;

        if (health > maxHealth) {
            health = maxHealth;
        }else if (health <= 0)
        {
            animator.SetTrigger("Hurt");
            health = 0;
            //healthBar.SetHealth(health);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        isHurt = false;
    }

    private void Update()
    {
        healthBar.SetHealth(health);

        if (saver == true)
        {
            LoadPlayer();
        }

        if (move.x != 0 || move.y != 0)
        {
            animator.SetBool(runID, isMoving);
        }
        if (health <= 0)
        {
            //animator.SetTrigger("Dead");
            health = 0;
            //healthBar.SetHealth(health);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (hasLunged == true)
        {
            transform.position += (Vector3)move * speed * lungeDistance * Time.deltaTime;
            hasLunged = false;
        }

        if(health <= 0)
        {
            LoadPlayer();
        }
    }
    void FixedUpdate()
    {
        Vector3Int gridPos = floorTilemap.WorldToCell(transform.position + (Vector3)move);
        isMoving = false;

        if (move.x != 0 || move.y != 0)
        {
            isMoving = true;

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
                transform.position += (Vector3)move * speed * Time.fixedDeltaTime;
            }
            animator.SetBool(runID, isMoving);
        }
        else
        {
            //Debug.Log("PROTECT");
            isMoving = false;
        }
    }
    
    #region SKILLS
    public void Lunge()
    {
        move = controls.Susana.Move.ReadValue<Vector2>();
        if (CanLunge(move) && abilities.lungeCooldown == false)
        {
            LungeLogic();
            hasLunged = true;
            animator.SetTrigger("Lunge");
            //transform.position += (Vector3)move * lungeDistance * Time.deltaTime;
            //rb.velocity = new Vector2(lungeDistance, rb.velocity.y);
        }
    }
    private bool CanLunge(Vector2 lungeToNext)
    {
        Vector3Int gridPos = floorTilemap.WorldToCell(transform.position + (Vector3)move);
        Vector3Int lungeGridPos = floorTilemap.WorldToCell(transform.position + (Vector3)move * 2);
        if (!floorTilemap.HasTile(gridPos) || collisionTilemap.HasTile(gridPos) ||
            !floorTilemap.HasTile(lungeGridPos) || collisionTilemap.HasTile(lungeGridPos))
        {
            return false;
        }
        else if (move.x == 0 && move.y == 0)
        {
            return false;
        }
        lunging = true;
        return true;
    }

    public void LungeLogic()
    {
        Vector2 pos = transform.position;

        GameObject lungeFX = Instantiate(lungePrefab, pos, transform.rotation);
    }

    public void Earthquake()
    {
        quaking = true;
        if (abilities.earthquakeCooldown == false)
        {
            quaking = true;
            //sprite.color = new Color(0, 0, 1, 1);
            EarthquakeLogic();
            Camera.main.GetComponent<CameraFollow>().shakeDuration = 0.2f;
        }
        //sprite.color = new Color(1, 1, 1, 1);
        //Camera.main.GetComponent<CameraShake>().shakeDuration = 0.2f;
        //gameHandler.GetComponent<CameraShake>().shakeDuration = 0.2f;
    }

    public void EarthquakeLogic()
    {
        Vector2 pos = transform.position;

        GameObject earthquakeFX = Instantiate(earthquakePrefab, pos, transform.rotation);
    }


    private void Shield()
    {
        /*if (health < 100)
        {
            Debug.Log(health + "JODER");
            state = State.HEALING;
            defending = true;
            health = health * 10;
            UpdateHealth(health);
        }
        state = State.IDLE;*/
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    #endregion

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void SavePlayer()
    {
        SaveSystem.SaveSusana(this);
    }

    public void LoadPlayer()
    {
        SusanaData data = SaveSystem.LoadSusana();

        //level = susana.level;
        health = data.health;
        nPotions = data.potions;
        nKeys = data.keys;
        nBombs = data.bombs;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //This to a manager
        if (collision.tag == "SavePoint")
        {
            SavePlayer();
        }

        else if(collision.tag == "Fireball")
        {
            animator.SetTrigger("Hurt");
            health -= 20;
        }
        
        else if (collision.tag == "Potion")
        {
            GameManager.Instance.potionNumber++;
            nPotions++;
        }
        
        else if (collision.tag == "Key")
        {
            GameManager.Instance.keyNumber++;
            nKeys++;
        }
        else if (collision.tag == "NPC")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (collision.tag == "Door" && GameManager.Instance.keyNumber >= 1)
        {
            Debug.Log("Has usado una llave!");
            GameManager.Instance.keyNumber--;
            collision.gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "DamagingTile")
        {
            animator.SetTrigger("Hurt");
            UpdateHealth(1);
        }
        else if (collision.tag == "HealingTile")
        {
            UpdateHealth(-2);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //This to a manager
        if (collision.tag == "SavePoint")
        {
            if (saver == true)
            {
                LoadPlayer();
            }
        }
    }

    public void continueMatch()
    {
        SceneManager.LoadScene("MainRoomv3", LoadSceneMode.Single);
        LoadPlayer();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }



    public void Heal()
    {
        state = State.HEALING;
        const int healAmount = 100;

        if (GameManager.Instance.potionNumber >= 1)
        {
            Debug.Log("Has usado una poción!");
            if (health <= (maxHealth - healAmount))
            {
                PotionLogic();
                health += healAmount;
                GameManager.Instance.potionNumber--;
            }
            else
            {
                PotionLogic();
                health = maxHealth;
                GameManager.Instance.potionNumber--;
            }
        }
    }

    public void PotionLogic()
    {
        Vector2 pos = transform.position;

        GameObject potionFX = Instantiate(potionPrefab, pos, transform.rotation);
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
