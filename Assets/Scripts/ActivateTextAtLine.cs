using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTextAtLine : MonoBehaviour
{
    public TextAsset text;

    public int startLine;
    public int endLine;

    public DialogManager dialog;

    private PickupInput startDialogControls;

    public bool mustButtonPress;
    private bool waitForPress;

    public bool destroyWhenActivated;
    private InputAction.CallbackContext ctx;

    private void Awake()
    {
        startDialogControls = new PickupInput();
    }

    private void OnEnable()
    {
        startDialogControls.Enable();
    }

    private void OnDisable()
    {
        startDialogControls.Disable();
    }

    // Start is called before the first frame update
    void Start() {
        dialog = FindObjectOfType<DialogManager>();

        startDialogControls.Floor.Pickup.performed += ctx => StartTalk(ctx);
    }

    void StartTalk(InputAction.CallbackContext ctx)
    {
        if (waitForPress && ctx.performed) {
            dialog.ReloadScript(text);
            dialog.currentLine = startLine;
            dialog.endAtLine = endLine;
            dialog.EnableTextBox();
        }
    }

    // Update is called once per frame
    void Update() {
        StartTalk(ctx);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Susana")
        {
            if(mustButtonPress)
            {
                waitForPress = true;
                return;
            }

            dialog.ReloadScript(text);
            dialog.currentLine = startLine;
            dialog.endAtLine = endLine;
            dialog.EnableTextBox();

            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Susana")
        {
            waitForPress = true;
        }
    }
}
