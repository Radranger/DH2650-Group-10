using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DriverClickReady : MonoBehaviour
{
    public Toggle Toggle;
    // Set togggle to ready when space has been pressed
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Toggle.isOn = !Toggle.isOn;
        }
    }
}
