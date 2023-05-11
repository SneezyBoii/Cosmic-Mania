using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetRot : MonoBehaviour
{

    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Vertical") * tiltAngle; 
        float tiltAroundX = Input.GetAxis("Horizontal") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX,90, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);


    }
}