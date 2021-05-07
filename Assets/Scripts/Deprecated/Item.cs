using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Item : MonoBehaviour
{
 
    [SerializeField]
    private Tilemap floorItemsTilemap;

    [SerializeField]
    private int nPotions;

    [SerializeField]
    private Tilemap keyTilemap;

    [SerializeField]
    private int nKeys;

    private PickupInput pickupControls;

    SusanaController susanaController;

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
        nPotions = 0;
        nKeys = 0;
        pickupControls.Floor.Pickup.performed += ctx => Pickup();
    }

    /*public int NumPotions()
    {
        return nPotions;
    }*/

    private void Pickup()
    {
        Vector3Int gridPosition = floorItemsTilemap.WorldToCell(transform.position);
        if (ItemOnFloor())
        {
            floorItemsTilemap.SetTile(gridPosition, null);
            //nPotions++;
            GameManager.Instance.potionNumber++;
        }

        Vector3Int keyGridPosition = keyTilemap.WorldToCell(transform.position);
        if (KeyOnFloor())
        {
            keyTilemap.SetTile(keyGridPosition, null);
            GameManager.Instance.keyNumber++;
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

    private bool KeyOnFloor()
    {
        Vector3Int keyGridPosition = keyTilemap.WorldToCell(transform.position);
        if (!keyTilemap.HasTile(keyGridPosition))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
