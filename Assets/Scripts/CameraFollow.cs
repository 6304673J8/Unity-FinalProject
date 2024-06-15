using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Func<Vector3> GetCameraFollowPositionFunc;

    public GameObject followTarget;
    private Vector3 targetPos;
    public float moveSpeed;

    // How long the object should shake for.
    public float shakeDuration = 0f;
    
    // Amplitude of the shake. A larger value shakes the camera harder.
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;
    void Update()
    {
        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        Vector3 velocity = targetPos - transform.position;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, 1.0f, moveSpeed * Time.deltaTime);

        if (shakeDuration > 0)
        {
            transform.localPosition = targetPos + UnityEngine.Random.insideUnitSphere * shakeAmount;

            shakeDuration -= Time.deltaTime * decreaseFactor;
        }
    }

    public void Setup(Func<Vector3> GetCameraFollowPositionFunc)
    {
        this.GetCameraFollowPositionFunc = GetCameraFollowPositionFunc;
    }
}
    

