using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject openedDoor;

    public void destroyDoor()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Susana")
        {
            if(GameManager.Instance.keyNumber >= 1)
            {
                GameManager.Instance.keyNumber = 0;
                FindObjectOfType<SoundManager>().Play("OpenDoor");
                GameObject opd = Instantiate(openedDoor, transform.position, transform.rotation);
                destroyDoor();
            }
        }
    }
}
