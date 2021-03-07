using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //testttt
    //public enum Character { NONE, SUSANA, AI }; //Enumerador de personajes
    public enum Direction { NONE, UP, DOWN, LEFT, RIGHT }; //Enumerador de direcciones

    public float speed = 3f; //Velocidad de movimiento de Susana

    //private float currentSpeedV = 0; //Velocidad vertical
    //private float currentSpeedH = 0; //Velocidad horizontal

    private KeyCode upButton = KeyCode.W; //Tecla para que Susana vaya arriba
    private KeyCode downButton = KeyCode.S; //Tecla para que Susana vaya abajo
    private KeyCode leftButton = KeyCode.A; //Tecla para que Susana vaya para la izquierda
    private KeyCode rightButton = KeyCode.D; //Tecla para que Susana vaya para la derecha

    private Direction dir = Direction.NONE; //Dirección asignada a una variable

    private Rigidbody2D rigidBody;
    private BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime * 1000; //Milisegundos desde el último frame

        dir = Direction.NONE;

        if (Input.GetKey(upButton))
        {
            dir = Direction.UP;
        }
        else if (Input.GetKey(downButton))
        {
            dir = Direction.DOWN;
        }
        
        if (Input.GetKey(leftButton))
        {
            dir = Direction.LEFT;
        }
        else if (Input.GetKey(rightButton))
        {
            dir = Direction.RIGHT;
        }
    }

    private void FixedUpdate()
    {
        float delta = Time.fixedDeltaTime * 1000; //Milisegundos desde el último frame

        if (dir == Direction.UP)
        {
            rigidBody.AddForce(transform.up * speed * delta);
        }
        else if (dir == Direction.DOWN)
        {
            rigidBody.AddForce(-transform.up * -speed * delta * -1);
        }

        if (dir == Direction.UP)
        {
            rigidBody.AddForce(transform.up * speed * delta);
        }
        else if (dir == Direction.DOWN)
        {
            rigidBody.AddForce(-transform.up * -speed * delta * -1);
        }

        if (dir == Direction.LEFT)
        {
            rigidBody.AddForce(-transform.right * -speed * delta * -1);
        }
        else if (dir == Direction.RIGHT)
        {
            rigidBody.AddForce(transform.right * speed * delta);
        }

        /*currentSpeedV = 0;
        currentSpeedH = 0;

        switch (dir)
        {
            default: break;
            case Direction.UP:
                currentSpeedV = speed;
                break;
            case Direction.DOWN:
                currentSpeedV = -speed;
                break;
            case Direction.LEFT:
                currentSpeedH = speed;
                break;
            case Direction.RIGHT:
                currentSpeedH = -speed;
                break;
        }
        rigidBody.velocity = new Vector2(0, currentSpeedV) * delta;
        rigidBody.velocity = new Vector2(0, currentSpeedH) * delta;*/
    }
}
