using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject openedDoor;
    public GameObject doorSound;

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
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Susana")
        {
            if(keyManager.Instance.keyNum >= 1)
            {
                keyManager.Instance.keyNum = 0;
                GameManager.Instance.keyNumber = 0;
                //FindObjectOfType<SoundManager>().Play("OpenDoor");
                GameObject opd = Instantiate(openedDoor, transform.position, transform.rotation);
                GameObject drs = Instantiate(doorSound, transform.position, transform.rotation);
                destroyDoor();
            }
           
        }
    }
}
