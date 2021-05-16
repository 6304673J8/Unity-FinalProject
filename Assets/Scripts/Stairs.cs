using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class Stairs : MonoBehaviour
{
    private PlayerInput stairsControls;

    public Transform susana;

    private void Awake()
    {
        stairsControls = new PlayerInput();
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
        //Vector3 stairstut = new Vector3(70.5f, 0.5f, 0);
        Vector3 stairstut = new Vector3(15.5f, 71.5f, 0);

        Vector3 stairs1a = new Vector3(-18.5f, -4.5f, 0);
        Vector3 stairs2a = new Vector3(-8.5f, 46.5f, 0);
        Vector3 stairs3a = new Vector3(-3.5f, 46.5f, 0);

        Vector3 stairs1b = new Vector3(11.5f, 61.5f, 0);

        //if (transform.position == new Vector3(-9.5f, -1.5f, 0))
        if (Vector3.Distance(transform.position, stairs1a) < 0.5f /*&& keyManager.Instance.keyNum >= 3*/)
        {
            transform.position = stairs2a;
            keyManager.Instance.restartNum();
        } else if (Vector3.Distance(transform.position, stairs2a) < 0.5f)
        {
            transform.position = stairs1a;
        } else if (Vector3.Distance(transform.position, stairs3a) < 0.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else if (Vector3.Distance(transform.position, stairstut) < 0.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else if (Vector3.Distance(transform.position, stairs1b) < 0.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
