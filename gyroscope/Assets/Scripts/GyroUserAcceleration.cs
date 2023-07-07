using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroUserAcceleration : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Input.gyro.updateInterval = .1f;
    }
    void Update()
    {
        var value = Input.gyro.userAcceleration;
        if (value.magnitude < .5f)
        {
            transform.Translate(value);
        }


    }
}
