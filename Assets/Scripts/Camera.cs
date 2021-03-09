using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform susana;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(susana.position.x + offset.x, susana.position.y + offset.y, offset.z);
    }
}