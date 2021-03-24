using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Item ItemSusana;
    public static GameManager Instance { get; private set; }
    //Text potions;
    //Text keys;
    public int potionNumber;
    public int keyNumber;
    // Start is called before the first frame update

    private void Awake()
    {
        potionNumber = 0;
        keyNumber = 0;
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.Log("Multiples " + this);
        }
    }

   /* void Start()
    {
        potions = GetComponent<Text>();
        keys = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        potions.text = "x" + potionNumber;
        keys.text = "x" + keyNumber;
        //Debug.Log(ItemSusana.NumPotions());
    }*/
}
