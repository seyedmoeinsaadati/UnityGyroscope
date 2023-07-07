using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroAttitude : MonoBehaviour
{
    public Vector3 weightAxis = Vector3.one;

    private Vector3 rotationValue;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        rotationValue = Input.gyro.attitude.eulerAngles;

        rotationValue.x *= weightAxis.x;
        rotationValue.y *= weightAxis.y;
        rotationValue.z *= weightAxis.z;

        transform.localRotation = Quaternion.Euler(rotationValue);
    }
}
