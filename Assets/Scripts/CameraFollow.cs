using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Func<Vector3> GetCameraFollowPositionFunc;

    public void Setup(Func<Vector3> GetCameraFollowPositionFunc)
    {
        this.GetCameraFollowPositionFunc = GetCameraFollowPositionFunc;
    }


    /// <summary>
    /// //test
    /// </summary>
    /// 

    public Transform camTransform;

    // How long the object should shake for.
    public float shakeDuration = 0f;

    // Amplitude of the shake. A larger value shakes the camera harder.
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;

    Vector3 originalPos;

    void OnEnable()
    {
        //originalPos = GetCameraFollowPositionFunc();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraFollowSusana = GetCameraFollowPositionFunc();
        cameraFollowSusana.z = transform.position.z;

        Vector3 cameraMoveDir = (cameraFollowSusana - transform.position).normalized;
        float distance = Vector3.Distance(cameraFollowSusana, transform.position);
        float cameraMoveSpeed = 1.5f;

        if (shakeDuration > 0)
        {
            camTransform.localPosition = cameraFollowSusana + UnityEngine.Random.insideUnitSphere * shakeAmount;

            shakeDuration -= Time.deltaTime * decreaseFactor;
        }
        /*else
        {
            shakeDuration = 0f;
            camTransform.localPosition = cameraFollowSusana;
        }*/

        if (distance > 0)
        {
            Vector3 newCameraPosition = transform.position + cameraMoveDir * distance * cameraMoveSpeed * Time.deltaTime;

            float distanceAfterMoving = Vector3.Distance(newCameraPosition, cameraFollowSusana);

            if(distanceAfterMoving > distance)
            {
                newCameraPosition = cameraFollowSusana;
            }
            transform.position = newCameraPosition;
        }
    }
}
