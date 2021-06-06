using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public bool isPaused;

    public GameObject pauseMenuCanvas;

    private void Awake()
    {
        sceneControls = new PlayerInputs();
    }

    // Start is called before the first frame update
    void Start()
    {
        sceneControls.Susana.Pause.performed += ctx => Pause();
        isPaused = false;
    }
    private PlayerInputs sceneControls;

    private void OnEnable()
    {
        sceneControls.Enable();
    }

    private void OnDisable()
    {
        sceneControls.Disable();
    }

    private void Update()
    {
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }

        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void Pause()
    {
        isPaused = !isPaused;
    }

    public void mainMenu() //AQUI PONER LO DE GUARDAR
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void quitGame()
    {
        Application.Quit(0);
    }

    /*public bool isPaused;

    public GameObject pauseMenuCanvas;


    private void Update()
    {
        if(isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }

        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            isPaused = !isPaused;
        }
    }

    public void Resume()
    {
        isPaused = false;
    }

    public void mainMenu() //AQUI PONER LO DE GUARDAR
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void quitGame()
    {
        Application.Quit(0);
    }*/
}
