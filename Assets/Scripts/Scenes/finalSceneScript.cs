using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalSceneScript : MonoBehaviour
{

    private float timer = 19f;

    private float elapsed;

    private PlayerInputs sceneControls;


    private void Awake()
    {
        sceneControls = new PlayerInputs();
    }

    // Start is called before the first frame update
    void Start()
    {
        elapsed += Time.deltaTime;
        sceneControls.Floor.Next.performed += ctx => MainMenuScene();
    }


    private void OnEnable()
    {
        sceneControls.Enable();
    }

    private void OnDisable()
    {
        sceneControls.Disable();
    }

    private void MainMenuScene()
    {
        SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if (elapsed >= timer)
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }
}
