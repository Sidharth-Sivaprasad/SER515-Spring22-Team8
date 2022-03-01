using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel_Movement : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;

    public float acceleration = 500f;
    public float breakingForce = 300f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;

    private void FixedUpdate()
    {
        currentAcceleration = acceleration * Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;
        else
            currentBreakForce = 0f;

        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;

        frontRight.brakeTorque = currentBreakForce;
        frontRight.brakeTorque = currentBreakForce;
    }
}
