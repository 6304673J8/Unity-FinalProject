using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    enum Direction
    {
       NORTH, SOUTH, EAST, WEST
    }

    Vector3[] directionList = new Vector3[]
    {
        Vector3.up,
        Vector3.down,
        Vector3.right,
        Vector3.left
    };

    private PlayerInput controller;
    private SusanaGridMovement SusanaGridMovement;

    private Direction direction = Direction.SOUTH;

    private Vector2 vector2Dir;
    private Vector2 input;

    private void OnMove(InputValue value)
    {
        input = value.Get<Vector2>();
    }

    void Start()
    {
        if (!SusanaGridMovement)
        {
            SusanaGridMovement = GetComponent<SusanaGridMovement>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Player Has Pressed Key
        if(input != Vector2.zero)
        {
            //Key Pressed to (Abs)olute = Can't Walk Diagonally  
            if (Mathf.Abs(input.x) > Mathf.Abs(input.y))
            {
                if( input.x > 0)
                {
                    direction = Direction.EAST;
                } 
                else
                {
                    direction = Direction.WEST;
                }
            }
            else
            {
                if (input.y > 0)
                {
                    direction = Direction.NORTH;
                }
                else
                {
                    direction = Direction.SOUTH;
                }
            }
            vector2Dir = directionList[(int)direction];
        }
        else
        {
            vector2Dir = Vector2.zero;
        }
        SusanaGridMovement.SetDirection(vector2Dir);
    }
}
