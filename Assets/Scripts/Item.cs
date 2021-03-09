using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Item : MonoBehaviour
{
    //public TileBase[] tiles;
    //private RoomManager roomManager;

    [SerializeField]
    private Tilemap floorItemsTilemap;
    //private Tilemap floorTilemap;

    public GameObject floorItemsGameObject;

    private PickupInput pickupControls;
    //public int numPociones = 1;
    //public GameItem item;

    /*public void OnTriggerEnter2D(Collider2D col)
    {
        SusanaController susana = col.GetComponent<SusanaController>();
    }*/

    //private KeyCode pickupButton = KeyCode.Alpha1; //Tecla para que Susana recoja el objeto
    //public LayerMask floor;

    //private Rigidbody2D rigidBody;

    private void Awake()
    {
        pickupControls = new PickupInput();
        //roomManager = FindObjectOfType<RoomManager>()
    }

    private void OnEnable()
    {
        pickupControls.Enable();
    }

    private void OnDisable()
    {
        pickupControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        pickupControls.Floor.Pickup.performed += ctx => Pickup(/*ctx.ReadValue<Vector2>()*/);
        //rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Pickup(/*Vector2 posItem*/)
    {
        Vector3Int gridPosition = floorItemsTilemap.WorldToCell(transform.position);
        if (ItemOnFloor(/*RELLENAR*/))
        {
            floorItemsTilemap.SetTile(gridPosition, null);
            //Objecto++
            //Destruir objeto del suelo. Destroy(gameObject);
        }
    }

    private bool ItemOnFloor(/*Vector2 posItem*/) {
        Vector3Int gridPosition = floorItemsTilemap.WorldToCell(transform.position);
        if (!floorItemsTilemap.HasTile(gridPosition))
        {
            return false;
        } else
        {
            return true;
        }
        //Comprueba que la posición de Susana es la misma que la de un ítem
    }

    // Update is called once per frame
    void Update()
    {

    }
}
