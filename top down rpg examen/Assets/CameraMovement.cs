using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    public float smoothing;

    void LateUpdate()
    {
        Vector3 camPos = player.transform.position + offset;

        Vector3 smoothPos = Vector3.Lerp(transform.position, camPos, smoothing * Time.deltaTime);
        transform.position = smoothPos;
    }
}
