using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Debug.Log("Si esto fuera una Build, el juego se habría cerrado.");
        Application.Quit();
    }

    /*
         var eventSystem = EventSystemManager.currentSystem;
        eventSystem.SetSelectedGameObject( gameObject, new BaseEventData(eventSystem));
     
     
         using UnityEngine.EventSystems;
     
        //set this in the Inspector
        [SerializeField]
        private GameObject itemsButton;
     
        public void OpenCloseMenu()
        {
            //toggle menu window open/closed
            mainMenu.SetActive(!mainMenu.activeSelf);
            //set Items button as first selected
            var eventSystem = EventSystem.current;
            eventSystem.SetSelectedGameObject(itemsButton, new BaseEventData(eventSystem));
            //update menu data
            UpdateMainStats();
        }

     */
}
