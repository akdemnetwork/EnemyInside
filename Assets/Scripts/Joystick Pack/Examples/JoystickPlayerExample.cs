using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public float YonZ,YonX;
    public float JoyStickDegerZ;


    
    public void FixedUpdate()
    {
        YonX = variableJoystick.Horizontal;
        YonZ = variableJoystick.Vertical;
        if (YonZ<=-0.0001)
        {
            JoyStickDegerZ = -1.2f;
        }
        else if (YonZ>=0.0001)
        {
            JoyStickDegerZ = 1.2f;
        }
        else {
            JoyStickDegerZ = 0;

        }
        transform.Rotate(transform.rotation.x, YonX*65*Time.deltaTime, transform.rotation.z);
        transform.Translate(YonX*speed*Time.deltaTime, 0, JoyStickDegerZ* speed * Time.deltaTime);
    }

}
