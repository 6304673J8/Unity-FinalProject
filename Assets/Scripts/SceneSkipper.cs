using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSkipper : MonoBehaviour
{
    private SceneInput sceneControls;

    //SusanaController susanaController;
    private void Awake()
    {
        sceneControls = new SceneInput();
    }

    private void OnEnable()
    {
        sceneControls.Enable();
    }

    private void OnDisable()
    {
        sceneControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        sceneControls.Scene.Previous.performed += ctx => PreviousScene();
        sceneControls.Scene.Next.performed += ctx => NextScene();
    }

    private void PreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
