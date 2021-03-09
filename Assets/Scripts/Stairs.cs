using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Stairs : MonoBehaviour
{
    private PickupInput stairsControls;

    public Transform susana;

    private void Awake()
    {
        stairsControls = new PickupInput();
    }

    private void OnEnable()
    {
        stairsControls.Enable();
    }

    private void OnDisable()
    {
        stairsControls.Disable();
    }

    void Start()
    {
        stairsControls.Floor.Pickup.performed += ctx => StairsOnFloor();
    }

    private void StairsOnFloor()
    {
        if (transform.position == new Vector3(-9.5f, -1.5f, 0))
        {
            transform.position = new Vector3(-4.5f, 18.5f, 0);
        } else if (transform.position == new Vector3(-4.5f, 18.5f, 0))
        {
            transform.position = new Vector3(-9.5f, -1.5f, 0);
        }
    }

    /*private PickupInput stairsControls;

    public Transform susana;

    // Start is called before the first frame update
    void Start()
    {
        stairsControls.Floor.Pickup.performed += ctx => StairsOnFloor();
    }

    // Update is called once per frame
    private void StairsOnFloor()
    {
        Vector3 susanaPos = new Vector3(susana.position.x, susana.position.y, 0);
        Vector3 stairsf1down = new Vector3(-9.5f, -1.5f, 0);
        Vector3 stairsf2up = new Vector3(-4.5f, 18.5f, 0);
        if (susanaPos == stairsf1down)
        {
            transform.position = stairsf2up;
        }
        else
        {
        }
        //Vector3 stairsf1down = new Vector3(-9.5f, -1.5f, 0);
        //Vector3 stairsf2up = new Vector3(-4.5f, 18.5f, 0);
        /*if (susanaVector == stairsf1down){
            susanaVector = stairsf2up;
            Instantiate(susana, stairsf2up);
            return true;
        } else if (susanaVector == stairsf2up) {
            susanaVector = stairsf1down;
            return true;
        } else
        {
            return false;
        }
    }*/

    /*public enum Way { UPSTAIRS, DOWNSTAIRS };
    [SerializeField] Transform teleportTo;
    //[SerializeField] string tag = "Susana";
    [SerializeField] Way way;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (way = Way.DOWNSTAIRS)
        {
            return;
        }
        if (tag == string.Empty || other.CompareTag(tag))
        {
            other.transform.position = teleportTo.position;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (way != Way.UPSTAIRS)
        {
            return;
        }
        if (tag == string.Empty || other.CompareTag(tag))
        {
            other.transform.position = teleportTo.position;
        }
    }*/
}
