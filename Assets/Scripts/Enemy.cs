using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 1f;
    public float range;
    public int hp;
    public int damage;
    private float lastAttackTime;
    public float attackDelay;
    private Rigidbody2D enemyrb;
    private Vector2 movement;
    // Start is called before the first frame update 
    void Start()
    {
        enemyrb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame 
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;

        //Comprobar la distancia entre el enemigo y el jugador
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if(distanceToPlayer < range)
        {
            player.SendMessage("TakeDamage", damage);
            //Guardamos la última vez que hemos atacado para el delay
            lastAttackTime = Time.time;
        }
    }

    private void FixedUpdate()
    {
        moveEnemy(movement);
    }

    void moveEnemy(Vector2 direction)
    {
        enemyrb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

  
}