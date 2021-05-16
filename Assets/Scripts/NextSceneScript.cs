using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextSceneScript : MonoBehaviour
{

    private float timer = 30f;

    private float elapsed;

    private void Awake()
    {
        sceneControls = new PlayerInputs();
    }

    // Start is called before the first frame update
    void Start()
    {
        elapsed += Time.deltaTime;
        sceneControls.Floor.Next.performed += ctx => NextScene();
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

    private void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if(elapsed>=timer)
        {
            //SceneManager.LoadScene("TutorialRoom", LoadSceneMode.Single);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
