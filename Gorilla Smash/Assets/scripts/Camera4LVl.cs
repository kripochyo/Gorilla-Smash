using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera4LVl : MonoBehaviour
{
    public float minAngle;
    public float maxAngle;
    public Transform CameraAxisTransform;
    public float RotationSpeed;
    private void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X"), 0);

       
    }
}
