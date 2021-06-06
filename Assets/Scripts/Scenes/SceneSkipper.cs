using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSkipper : MonoBehaviour
{
    private PlayerInputs sceneControls;

    //SusanaController susanaController;
    private void Awake()
    {
        sceneControls = new PlayerInputs();
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
        sceneControls.Susana.Previous.performed += ctx => PreviousScene();
        sceneControls.Susana.Next.performed += ctx => NextScene();
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
