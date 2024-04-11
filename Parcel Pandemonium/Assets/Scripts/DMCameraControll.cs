using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMCameraControll : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCamera = 0;
    void Update()
    {
        //change camera when pressing numpad keys
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            currentCamera = 0;
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            currentCamera = 1;
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            currentCamera = 2;
        }
        //change camera when pressing gamepad buttons
        if (Input.GetKeyDown(KeyCode.JoystickButton4))
        {   
            if (currentCamera > 0)
            {
                currentCamera--;
            }
            else
            {
                currentCamera = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton5))
        {
            if (currentCamera < 2)
            {
                currentCamera++;
            }
            else
            {
                currentCamera = 0;
            }
        }
        //change camera
        for (int i = 0; i < cameras.Length; i++)
        {
            if (i == currentCamera)
            {
                cameras[i].enabled = true;
            }
            else
            {
                cameras[i].enabled = false;
            }
        }
    }
}
