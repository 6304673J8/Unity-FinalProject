using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject openedDoor;

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
        GameObject gb = Instantiate(openedDoor, transform.position, transform.rotation);
    }
}
