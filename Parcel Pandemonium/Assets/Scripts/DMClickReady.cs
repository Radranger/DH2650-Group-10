using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DMClickReady : MonoBehaviour
{
    public Toggle Toggle;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Debug.Log("Keypad5 pressed");
            Toggle.isOn = !Toggle.isOn;
        }
    }
}
