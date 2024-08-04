using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Label_ToCamera : MonoBehaviour
{
    private CinemachineVirtualCamera mainCamera;

    private void Start()
    {
        GameObject camera = GameObject.FindWithTag("MainCamera");
        if(camera != null)
        {
            mainCamera = camera.GetComponent<CinemachineVirtualCamera>();
        }
        LookTowardCamera();
    }
    private void Update() => LookTowardCamera();
    private void LookTowardCamera()
    {
        transform.forward = mainCamera.transform.forward;
    }
}
