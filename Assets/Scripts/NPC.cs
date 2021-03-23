/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class NPC : MonoBehaviour
{
    [SerializeField]
    private Tilemap NPCTilemap;

    private PickupInput talkControls;

    // Start is called before the first frame update
    private void Awake()
    {
        talkControls = new PickupInput();
    }

    private void OnEnable()
    {
        talkControls.Enable();
    }

    private void OnDisable()
    {
        talkControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        talkControls.Wall.Pickup.performed += ctx => NPCNear(ctx.ReadValue<Vector2>());
    }

    /*private void Talk(Vector2 dir)
    {
        Vector3Int gridPosition = NPCTilemap.WorldToCell(transform.position);
        dir = new Vector2Int(Mathf.FloorToInt(dir.x), Mathf.FloorToInt(dir.y));
        if (NPCNear(dir))
        {
            //Habla
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    */
/*
    private bool NPCNear(Vector2 dir)
    {
        Vector3Int gridPosition = NPCTilemap.WorldToCell(transform.position + (Vector3)dir);
        if (!NPCTilemap.HasTile(gridPosition))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}*/
