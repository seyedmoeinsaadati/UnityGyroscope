using UnityEngine;

public class TripleGyroscopeController : MonoBehaviour
{

    public bool biased;

    public Transform aRing, bRing, cRing;
    public float rotationSpeedA, rotationSpeedB, rotationSpeedC;

    private float dt;
    private Vector3 rotationValue;

    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        dt = Time.deltaTime;
        // rotationValue += biased ? Input.gyro.rotationRate : Input.gyro.rotationRateUnbiased;
        rotationValue = Input.gyro.attitude.eulerAngles;

        if (rotationValue.x > 180) rotationValue.x -= 360;

        if (rotationValue.y > 180) rotationValue.y -= 360;

        if (rotationValue.z > 180) rotationValue.z -= 360;

        aRing.Rotate((dt * rotationSpeedA * rotationValue.y) * Vector3.up, Space.Self);
        bRing.Rotate((dt * rotationSpeedB / 2 * rotationValue.x) * Vector3.right, Space.Self);
        cRing.Rotate((dt * rotationSpeedC / 4 * rotationValue.z) * Vector3.up, Space.Self);

        //aRing.localRotation = Quaternion.Euler((rotationSpeedA * rotationValue.y) * Vector3.up);
        //bRing.localRotation = Quaternion.Euler((rotationSpeedB * rotationValue.x) * Vector3.right);
        //cRing.localRotation = Quaternion.Euler((rotationSpeedC * rotationValue.z) * Vector3.up);

    }

    private void OnGUI()
    {
        GUILayout.Label($"Attitude: {rotationValue}");
    }

    public void OnSpeedChanged(float value)
    {
        rotationSpeedA = value;
        rotationSpeedB = value;
        rotationSpeedC = value;
    }

}
