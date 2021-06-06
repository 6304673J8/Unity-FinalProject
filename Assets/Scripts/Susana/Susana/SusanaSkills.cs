using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SusanaSkills : MonoBehaviour
{
    [Header("Player")]
    public Rigidbody2D rb;

    [Header("Abilities")]

    public GameObject earthquakePrefab;
    public GameObject lungePrefab;
    public GameObject potionPrefab;

    public void Awake()
    {
    }
    public void EarthquakeLogic()
    {
        Vector2 pos = rb.transform.position;

        GameObject earthquakeFX = Instantiate(earthquakePrefab, pos, rb.transform.rotation);
    }

    public void LungeLogic()
    {
        Vector2 pos = rb.transform.position;

        GameObject lungeFX = Instantiate(lungePrefab, pos, rb.transform.rotation);
    }

    public void PotionLogic()
    {
        Vector2 pos = rb.transform.position;

        GameObject potionFX = Instantiate(potionPrefab, pos, rb.transform.rotation);
    }
}
