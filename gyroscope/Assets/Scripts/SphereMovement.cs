using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public bool biased;
    public float rotationSpeed = 1;

    public Vector3 weightAxis = Vector3.one;

    private Vector3 rotationValue;

    void Start()
    {
        GyroInput.IsActive = true;
    }

    void Update()
    {
        rotationValue = biased ? Input.gyro.rotationRate : Input.gyro.rotationRateUnbiased;

        rotationValue.x *= weightAxis.x;
        rotationValue.y *= weightAxis.y;
        rotationValue.z *= weightAxis.z;

        transform.Rotate((Time.deltaTime * rotationSpeed) * rotationValue);
    }
}
