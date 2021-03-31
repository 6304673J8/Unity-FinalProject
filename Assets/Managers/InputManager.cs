using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [Header("Management Scripts")]
    [SerializeField] SusanaOmega susana;
    Vector2 axis;

    public void OnMove(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {

            axis = ctx.ReadValue<Vector2>();
        }
        if (ctx.canceled)
        {
            axis = Vector2.zero;
        }
        susana.SetAxis(axis);
    }

    public void OnLunge(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            susana.Lunge();
        }
    }

    public void OnDefense(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            susana.Defense();
        }
        if (ctx.canceled)
        {
            Debug.Log("WEEEEAK");
            //susana.Defense();
        }
    }
}
