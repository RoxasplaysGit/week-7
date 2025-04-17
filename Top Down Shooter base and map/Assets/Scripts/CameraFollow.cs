using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        //Calculate the target position with the offset
        Vector3 desiredPositon = player.position + offset;
        // Smoothly move the camera towards the target position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPositon, smoothSpeed);
        //Set the Camera's position to the smoothed position
        transform.position = smoothedPosition;
    }
}
