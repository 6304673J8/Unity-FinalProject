using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class Stairs : MonoBehaviour
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

    void Start()
    {
        stairsControls.Susana.Activate.performed += ctx => StairsOnFloor();
    }

    private void StairsOnFloor()
    {
        Vector3 stairstut = new Vector3(15.5f, 71.5f, 0);

        Vector3 stairs1a = new Vector3(-18.5f, -4.5f, 0);
        Vector3 stairs2a = new Vector3(-8.5f, 46.5f, 0);
        Vector3 stairs3a = new Vector3(-3.5f, 46.5f, 0);

        Vector3 stairs1b = new Vector3(11.5f, 61.5f, 0);
        Debug.Log("ScaIrs");
        if (Vector3.Distance(transform.position, stairs1a) < 0.5f)
        {
            transform.position = stairs2a;
            keyManager.Instance.restartNum();
        } else if (Vector3.Distance(transform.position, stairs2a) < 0.5f)
        {
            transform.position = stairs1a;
        } else if (Vector3.Distance(transform.position, stairs3a) < 0.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else if (Vector3.Distance(transform.position, stairstut) < 0.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else if (Vector3.Distance(transform.position, stairs1b) < 0.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
