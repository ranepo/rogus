using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothspeed = 0.125f; 

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;
    }
}
