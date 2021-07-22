using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotAirBalloon : MonoBehaviour
{
    public DialInteractable dial;
    public float thrust = 5f;
    public float speedRatio;
    private float hightRatio = 0.0f;
    private float previousDialAngle;
    private Rigidbody hotAirBalloonRigidBody;

    
    void Start()
    {
        hotAirBalloonRigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (previousDialAngle > dial.CurrentAngle)
        {
            // increase height
            hotAirBalloonRigidBody.AddForce(transform.up * thrust * speedRatio);

        }
        else if (previousDialAngle < dial.CurrentAngle)
        {
            // decrease height
            hotAirBalloonRigidBody.AddForce(transform.up * -thrust * speedRatio);
        }

        previousDialAngle = dial.CurrentAngle;
    }


    public void SpeedChanged(DialInteractable dial)
    {
        float ratio = dial.CurrentAngle / dial.RotationAngleMaximum;

        speedRatio = ratio;
    }
}
