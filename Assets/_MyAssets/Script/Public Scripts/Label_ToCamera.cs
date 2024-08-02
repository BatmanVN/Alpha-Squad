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
        //mainCamera = CinemachineVirtualCamera.main;
        LookTowardCamera();
    }
    private void Update() => LookTowardCamera();
    private void LookTowardCamera()
    {
        transform.LookAt(mainCamera.transform);
    }
}
