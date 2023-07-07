using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroRotationAxis : MonoBehaviour
{
    public bool biased;
    public float rotationSpeed = 1;
    public Vector3 weightAxis = Vector3.one;
    public Space space;

    private Vector3 rotationValue;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        rotationValue = biased ? Input.gyro.rotationRate : Input.gyro.rotationRateUnbiased;

        rotationValue.x *= weightAxis.x;
        rotationValue.y *= weightAxis.y;
        rotationValue.z *= weightAxis.z;

        transform.Rotate((Time.deltaTime * rotationSpeed) * rotationValue, space);
    }
}
