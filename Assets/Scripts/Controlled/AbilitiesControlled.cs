using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilitiesControlled : MonoBehaviour
{
    public SusanaControlled susanaInputs;
    [Header("Ability 1")]
    public Image EarthquakeImage;
    public float CD_Earthquake = 4;
    public bool earthquakeCooldown = false;

    [Header("Ability 2")]
    public Image LungeImage;
    public float CD_Lunge = 1;
    public bool lungeCooldown = false;

    [Header("Ability 3")]
    public Image ShieldImage;
    public float CD_Shield = 3;
    public bool shieldCooldown = false;

    // Start is called before the first frame update
    void Start()
    {
        EarthquakeImage.fillAmount = 0;
        LungeImage.fillAmount = 0;
        ShieldImage.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (susanaInputs.quaking == true)
        {
            Skill_E();
        }
        if (susanaInputs.lunging == true) {
            Skill_L();
        }
        if (susanaInputs.defending == true) { 
            Debug.Log("fkfkfkfk");
            Skill_S();
        }
    }

    public void Skill_E() {
        if (earthquakeCooldown == false) {
            earthquakeCooldown = true;
            EarthquakeImage.fillAmount = 1;
        }
        if (earthquakeCooldown)
        {
            EarthquakeImage.fillAmount -= 1 / CD_Earthquake * Time.deltaTime;

            if (EarthquakeImage.fillAmount <= 0)
            {
                EarthquakeImage.fillAmount = 0;
                earthquakeCooldown = false;
                susanaInputs.quaking = false;
            }
        }
    }

    public void Skill_L()
    {
        if (lungeCooldown == false)
        {
            lungeCooldown = true;
            LungeImage.fillAmount = 1;
        }
        if (lungeCooldown)
        {
            LungeImage.fillAmount -= 1 / CD_Lunge * Time.deltaTime;

            if (LungeImage.fillAmount <= 0)
            {
                LungeImage.fillAmount = 0;
                lungeCooldown = false;
                susanaInputs.lunging = false;
            }
        }
    }

    public void Skill_S()
    {
        if (shieldCooldown == false)
        {
            shieldCooldown = true;
            ShieldImage.fillAmount = 1;
        }
        if (shieldCooldown)
        {
            ShieldImage.fillAmount -= 1 / CD_Shield * Time.deltaTime;

            if (ShieldImage.fillAmount <= 0)
            {
                ShieldImage.fillAmount = 0;
                shieldCooldown = false;
            }
        }
    }
}
