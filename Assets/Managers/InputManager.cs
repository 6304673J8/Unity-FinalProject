using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
   /* PlayerInputs controls;
    [Header("Management Scripts")]
    [SerializeField] SusanaControlled susana;
    Vector2 axis;

    private void Awake() { 
    }

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

    public void OnShaker(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            susana.Earthquake();
        }
    }*/
}
