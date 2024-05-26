using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DriverClickReady : MonoBehaviour
{
    public Toggle Toggle;

    private bool hasBeenClicked = false;
    // Set togggle to ready when A on the gamepad or space is pressed
    void Update()
    {   
        if ((Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.Space)) && !hasBeenClicked)
        {
            Debug.Log("A button pressed");
            Toggle.isOn = true;
            hasBeenClicked = true;
        }
        else if ((Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.Space)) && hasBeenClicked)
        {
            Toggle.isOn = false;
            hasBeenClicked = false;
        }
    }
}
