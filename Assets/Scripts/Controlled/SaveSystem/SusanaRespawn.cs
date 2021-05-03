using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SusanaRespawn : MonoBehaviour
{
    private GameManager gm;
    PlayerInputs controls;

    private void Awake()
    {
        controls.Susana.Action.performed += ctx => Interact();
    }
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        transform.position = gm.lastCheckPoint;
    }

    private void Interact()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    /*private float checkPointX, checkPointY;
    
    void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointX") != 0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointX"),
                PlayerPrefs.GetFloat("checkPointY")));
        }
    }

    public void OnCheckPoint(float _x, float _y)
    {
        PlayerPrefs.SetFloat("checkPointX", _x);
        PlayerPrefs.SetFloat("checkPointY", _y);
    }*/
}
