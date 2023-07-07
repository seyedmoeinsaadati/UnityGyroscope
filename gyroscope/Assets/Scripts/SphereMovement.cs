using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public bool biased;
    public float rotationSpeed = 1;

    void Start()
    {
        GyroInput.IsActive = true;
    }

    void Update()
    {
        if (biased)
        {
            transform.Rotate(0, Time.deltaTime * rotationSpeed * (-Input.gyro.rotationRateUnbiased.y), 0);
        }
        else
        {
            transform.Rotate(0, Time.deltaTime * rotationSpeed * (-Input.gyro.rotationRateUnbiased.y), 0);
        }

    }
}
