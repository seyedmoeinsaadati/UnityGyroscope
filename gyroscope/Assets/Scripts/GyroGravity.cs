using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroGravity : MonoBehaviour
{
    public float movementScale;

    void Update()
    {
        // A "spirit level" - the dot product of the gravity and the Y axis (ie, Vector3.up)
        // is a measure of how far the device is from level on that axis (it will be zero
        // if the device is perfectly level). This value can be used to position an object
        // to act as the "bubble".
        Vector3 pos = transform.position;
        Debug.Log("Gyro Input:" + Input.gyro.gravity);
        pos.y = Vector3.Dot(Input.gyro.gravity, Vector3.up) * movementScale;
        transform.position = pos;
    }
}
