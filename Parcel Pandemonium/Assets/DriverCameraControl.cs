using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverCameraControl : MonoBehaviour
{
    public float rotationSpeed = 1;

    // Camera follows this object, this game object rotates with the right joystick on the gamepad to control the camera
    void Update()
    {
        // Get the right joystick input
        float horizontalInput = Input.GetAxis("RightJoystickHorizontal");
        float verticalInput = Input.GetAxis("RightJoystickVertical");

        // If no imput is given, the camera will rotate back to the initial position based on the parent object
        if (horizontalInput == 0 && verticalInput == 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, transform.parent.rotation, Time.deltaTime * 2);
        }

        // set some max values for the angles up and down
        float maxUpAngle = 45;
        float maxDownAngle = 45;

        // rotate the gameobject with the right joystick input, keep the angles within the max values and keep the camera horizontal
        transform.Rotate(-verticalInput * rotationSpeed, horizontalInput * rotationSpeed, 0);

        if (transform.eulerAngles.x > 180 && transform.eulerAngles.x < 360 - maxUpAngle)
        {
            transform.eulerAngles = new Vector3(360 - maxUpAngle, transform.eulerAngles.y, transform.eulerAngles.z);
        }
        else if (transform.eulerAngles.x < 180 && transform.eulerAngles.x > maxDownAngle)
        {
            transform.eulerAngles = new Vector3(maxDownAngle, transform.eulerAngles.y, transform.eulerAngles.z);
        }

        if(transform.eulerAngles.z != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        }


    }
}
