using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    Text potions;
    Text keys;
    public int potionNumber;
    public int keyNumber;
    // Start is called before the first frame update

    void Start()
    {
        potions = GetComponent<Text>();
        keys = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "Item")
        {
            potions.text = "x" + GameManager.Instance.potionNumber;
        } else if (tag == "Key") {
            keys.text = "x" + GameManager.Instance.keyNumber;
        }
        //Debug.Log(ItemSusana.NumPotions());
    }
}
