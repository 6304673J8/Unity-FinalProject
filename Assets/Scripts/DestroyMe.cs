using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    private bool isDestroyed = false;

    public GameObject destroyItem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDestroyed)
            return;

        if (collision.CompareTag("Earthquake"))
        {
            isDestroyed = true;
            GameObject di = Instantiate(destroyItem, transform.position, transform.rotation);
            Destroy(di, 2);
            Destroy(this.gameObject);
        }

        if (collision.CompareTag("Lunge"))
        {
            isDestroyed = true;
            GameObject di = Instantiate(destroyItem, transform.position, transform.rotation);
            Destroy(di, 2);
            Destroy(this.gameObject);
        }
    }
}
