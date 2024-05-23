using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMRotationControls : MonoBehaviour
{   
    public float rightRotation;
    public float leftRotation;
    public bool stopLeftRotation = false;
    public bool stopRightRotation = false;
    // Allow the user to rotate around the y axis with the arrow keys
    void Update()
    {   
        Debug.Log("Rotation: " + transform.rotation.y);
        // If Rotation is above rightRotation, stop rotation
        if (transform.localRotation.y > rightRotation)
        {
            stopRightRotation = true;
        }
        else
        {
            stopRightRotation = false;
        }
        // If Rotation is below leftRotation, stop rotation
        if (transform.rotation.y < leftRotation)
        {
            stopLeftRotation = true;
        }
        else
        {
            stopLeftRotation = false;
        }

        if (!stopLeftRotation)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up, -1);
            }
        }
        if (!stopRightRotation)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up, 1);
            }
        }

    }
}
