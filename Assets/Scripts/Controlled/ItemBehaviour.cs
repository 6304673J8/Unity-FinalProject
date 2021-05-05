using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{

    public bool isKey;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Susana"))
        {
            if(isKey)
            {
                keyManager.Instance.keyNum++;
            }
            GetComponent<SpriteRenderer>().enabled = false;
            //gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.5f);
            FindObjectOfType<SoundManager>().Play("itemPick");
            
        }
    }
}
