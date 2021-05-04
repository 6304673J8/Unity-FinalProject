using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextSceneScript : MonoBehaviour
{

    private float timer = 45f;

    private float elapsed;

    // Start is called before the first frame update
    void Start()
    {
        elapsed += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            //SceneManager.LoadScene("TutorialRoom", LoadSceneMode.Single);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if(elapsed>=timer)
        {
            //SceneManager.LoadScene("TutorialRoom", LoadSceneMode.Single);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
