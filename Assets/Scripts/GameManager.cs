using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public static GameManager Instance { get; private set; }
    //Text Items;
    public int potionNumber;
    public int keyNumber;
    
    public Vector2 lastCheckPoint;

    private void Awake()
    {
        potionNumber = 0;
        keyNumber = 0;
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
