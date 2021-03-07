using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Movimiento Susana
    public float mSpeed = 5.0f; //Velocidad de movimiento de Susana
    public Transform movePivot;
    Vector2 movement;

    //Colisionado con objetos
    public LayerMask obstacle;

    private Rigidbody2D rb;
    private BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        movePivot.parent = null;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        transform.position = Vector3.MoveTowards(transform.position, movePivot.position, mSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePivot.position) <= .05f) {
            if (Mathf.Abs(movement.x) == 1f)
            {
                movePivot.position += new Vector3(movement.x, 0f, 0f);
            } else if (Mathf.Abs(movement.y) == 1f)
            {
                movePivot.position += new Vector3(0, movement.y, 0f);
            }
        }

    }

    void FixedUpdate()
    {
        float delta = Time.fixedDeltaTime * 1000; //Milisegundos desde el último frame

        rb.MovePosition(rb.position + movement * mSpeed * Time.fixedDeltaTime);

    }
}
