using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    private bool isDestroyed = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDestroyed)
            return;

        if (collision.CompareTag("Susana"))
        {
            isDestroyed = true;
            Destroy(this.gameObject);
        }
    }
}
