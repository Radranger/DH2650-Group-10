using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMInteractions : MonoBehaviour
{
    public GameObject[] gameObjects;
    
    void Update()
    {

        // runs the gameObject functions when pressing numpad keys
        if ((Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.JoystickButton0)))
        {
            gameObjects[0].GetComponent<dmActivation>().Activate();
        }
        if ((Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.JoystickButton1)))
        {
            gameObjects[1].GetComponent<dmActivation>().Activate();
        }
        if ((Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.JoystickButton2)))
        {
            gameObjects[2].GetComponent<dmActivation>().Activate();
        }
        if ((Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.JoystickButton3)))
        {
            gameObjects[3].GetComponent<dmActivation>().Activate();
        }
        if ((Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.JoystickButton4)))
        {
            gameObjects[4].GetComponent<dmActivation>().Activate();
        }
        if ((Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.JoystickButton5)))
        {
            gameObjects[5].GetComponent<dmActivation>().Activate();
        }
        


    }
}
