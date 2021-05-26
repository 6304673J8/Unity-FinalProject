using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StairsSceneChange : MonoBehaviour
{
    private PlayerInputs stairsControls;
    public Transform susana;

    private void Awake()
    {
        stairsControls = new PlayerInputs();
    }

    private void OnEnable()
    {
        stairsControls.Enable();
    }

    private void OnDisable()
    {
        stairsControls.Disable();
    }

    void Update()
    {
        //stairsControls.Susana.Activate.performed += ctx => StairsOnFloor();
    }

    private void StairsOnFloor()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.tag == "Susana" && stairsControls.Susana.Action == true) {
            StairsOnFloor();
        }*/
    }
}
