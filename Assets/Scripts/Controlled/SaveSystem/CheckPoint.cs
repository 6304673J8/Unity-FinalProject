using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    //private float checkPointX, checkPointY;
    //private SusanaRespawn checkPoint;
    private GameManager gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Susana")) {
            gm.lastCheckPoint = transform.position;
            Debug.Log("CHECKED");
            FindObjectOfType<SoundManager>().Play("Checkpoint");
        }
    }
}
