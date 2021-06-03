using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    private bool isDestroyed = false;
    private Animator animator;
    public GameObject destroyItem;
    public GameObject drop;
    public bool canDrop;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDestroyed)
            return;

        if (collision.CompareTag("Earthquake"))
        {
            isDestroyed = true;
            animator.SetTrigger("Skill");
            GameObject di = Instantiate(destroyItem, transform.position, transform.rotation);
            if(canDrop)
            {
                GameObject drp = Instantiate(drop, transform.position, transform.rotation);
            }
            Destroy(di, 2);
            Destroy(this.gameObject, 0.8f);
        }

        if (collision.CompareTag("Lunge"))
        {
            isDestroyed = true;
            animator.SetTrigger("Skill");
            GameObject di = Instantiate(destroyItem, transform.position, transform.rotation);
            if (canDrop)
            {
                GameObject drp = Instantiate(drop, transform.position, transform.rotation);
            }
            Destroy(di, 2);
            Destroy(this.gameObject, 0.8f);
        }
    }
}
