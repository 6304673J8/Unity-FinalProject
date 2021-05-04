using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class DialogManager : MonoBehaviour
{
    public GameObject textBox;

    public Text text;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    private PickupInput dialogControls;

    public SusanaControlled susana;

    public bool isActive;

    public bool stopPlayerMovement;

    private void Awake()
    {
        dialogControls = new PickupInput();
    }

    private void OnEnable()
    {
        dialogControls.Enable();
    }

    private void OnDisable()
    {
        dialogControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        dialogControls.Floor.Pickup.performed += ctx => Talk(ctx);

        susana = FindObjectOfType<SusanaControlled>();

        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if(endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }

        if(isActive)
        {
            EnableTextBox();
        } else
        {
            DisableTextBox();
        }
    }

    void Talk(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            currentLine += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive)
        {
            return;
        }

        text.text = textLines[currentLine];

        //if (Input del 1){
        //  currentLine += 1;
        //}

        if (currentLine > endAtLine)
        {
            DisableTextBox();
        }
    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);
        isActive = true;

        if (stopPlayerMovement)
        {
            susana.canMove = false;
        }
    }

    public void DisableTextBox()
    {
        textBox.SetActive(false);
        isActive = false;
        susana.canMove = true;
    }

    public void ReloadScript(TextAsset text)
    {
        if(text != null)
        {
            textLines = new string[1];
            textLines = (text.text.Split('\n'));
        }
    }
}
