using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 1f;
    public float hp;
    public float damage;
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
        /*float angulo = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f; Con esto el enemigo se inclina hacia el jugador pero al tener sólo un sprite no nos hace falta 
        enemyrb.rotation = angulo;*/
        direction.Normalize();
        movement = direction;
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