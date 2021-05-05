using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health+4450;
        slider.value = health+4450;
    }

    public void SetHealth(int health)
    {
        slider.value = health+4450;
    }
}
