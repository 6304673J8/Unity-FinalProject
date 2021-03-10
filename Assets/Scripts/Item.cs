using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Item : MonoBehaviour
{
 
    [SerializeField]
    private Tilemap floorItemsTilemap;

    private PickupInput pickupControls;

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
        pickupControls.Floor.Pickup.performed += ctx => Pickup();
    }

    private void Pickup()
    {
        Vector3Int gridPosition = floorItemsTilemap.WorldToCell(transform.position);
        if (ItemOnFloor())
        {
            //Objecto++
            floorItemsTilemap.SetTile(gridPosition, null);
        }
    }

    //Comprueba que la posición de Susana es la misma que la de un ítem
    private bool ItemOnFloor() {
        Vector3Int gridPosition = floorItemsTilemap.WorldToCell(transform.position);
        if (!floorItemsTilemap.HasTile(gridPosition))
        {
            return false;
        } else
        {
            return true;
        }
    }

}
