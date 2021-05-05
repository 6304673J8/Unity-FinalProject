﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public GameObject playerR;
    public int damage;
    public float speed = 5;

    private Transform player;
    private Vector2 target;

    private Animator animator;

    private float beingDestroyed;

    private float destroyTime = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        

        player = GameObject.FindGameObjectWithTag("Susana").transform;

        playerR = GameObject.FindGameObjectWithTag("Susana");

        target = new Vector2(player.position.x, player.position.y);

        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime); 

        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Susana")
        {
            DestroyProjectile();
            playerR.SendMessage("TakeDamage", damage);
        }

        if (collision.tag == "Wall")
        {
            Destroy(gameObject);
        }

        if(collision.tag == "Enemy")
        {
            DestroyProjectile();
        }
    }


   /* private void OnCollisionEnter2D(Collision2D collision)
     {
         if(collision.gameObject.CompareTag("Susana") || collision.gameObject.CompareTag("Wall"))
         {
             Debug.Log("FIREBALL!");
             DestroyProjectile();
         }
     }*/

    void DestroyProjectile()
    {
        
        animator.SetTrigger("Destroyed");
        //speed = 0;
        beingDestroyed += Time.deltaTime;
        if(beingDestroyed >= destroyTime)
        {
            Destroy(gameObject);
        }
       
    }

    
}
