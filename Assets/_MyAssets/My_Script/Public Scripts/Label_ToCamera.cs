using UnityEngine;
using Cinemachine;
public class Label_ToCamera : MonoBehaviour
{
    private Transform cameraMain;
    private void Start()
    {
        cameraMain = Camera.main.transform;
    }
    private void LateUpdate()
    {
        transform.LookAt(transform.position + cameraMain.forward);
    }
}
