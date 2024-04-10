using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMCameraControll : MonoBehaviour
{
    public Camera[] cameras;
    void Update()
    {
        //change camera when pressing numpad keys
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            cameras[0].enabled = true;
            cameras[1].enabled = false;
            cameras[2].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            cameras[0].enabled = false;
            cameras[1].enabled = true;
            cameras[2].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            cameras[0].enabled = false;
            cameras[1].enabled = false;
            cameras[2].enabled = true;
        }
    }
}
