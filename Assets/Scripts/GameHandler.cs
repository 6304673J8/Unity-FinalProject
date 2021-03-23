using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public CameraFollow cameraFollow;
    public Transform susanaTransform;

    private void Start()
    {
        cameraFollow.Setup(() => (susanaTransform.position));
    }

}
