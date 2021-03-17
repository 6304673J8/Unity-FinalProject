using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public CameraFollow cameraFollow;
    public CameraShake cameraShake;
    public Transform susanaTransform;
    public Transform CameraTransform;

    private void Start()
    {
        cameraFollow.Setup(() => (susanaTransform.position));
    }

}
