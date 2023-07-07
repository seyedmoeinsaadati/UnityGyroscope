using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroInput : MonoBehaviour
{


    public static bool IsActive
    {
        get => Input.gyro.enabled;
        set => Input.gyro.enabled = value;
    }



}
