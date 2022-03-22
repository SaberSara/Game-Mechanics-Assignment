using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// A general script to make the camera follow the target smoothly (it allows parameters tweaking in the inspectors)
/// use it by attaching it to the Camera
/// </summary>

public class CameraFollow : MonoBehaviour
{
    [Header("Please fill :")]
    [SerializeField] private Transform target;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothTime;
    [SerializeField] private float maxSpeed;

    [Header("Watch only (Debug) :")] 
    private Vector3 velocity; 
    
    void LateUpdate()
    {
        cameraTransform.position = Vector3.SmoothDamp(cameraTransform.position, offset+target.position, ref velocity, smoothTime, maxSpeed);
    }
}
