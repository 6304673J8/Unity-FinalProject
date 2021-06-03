using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    //public GameObject openedDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void destroyDoor()
    {
        Destroy(gameObject);
       // GameObject gb = Instantiate(openedDoor, transform.position, transform.rotation);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Susana")
        {
            if(GameManager.Instance.keyNumber >= 1)
            {
                GameManager.Instance.keyNumber--;
                FindObjectOfType<SoundManager>().Play("OpenDoor");
                destroyDoor();
            }
           
        }
    }
}
