using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMRotationControls : MonoBehaviour
{   
    public float rightRotation;
    public float leftRotation;
    public bool stopLeftRotation = false;
    public bool stopRightRotation = false;
    public bool rotateRight = false;
    public bool rotateLeft = false;

    // Allow the user to rotate around the y axis with the arrow keys
    void Update()
    {   
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

        if (!stopRightRotation && rotateRight)
        {
            transform.Rotate(Vector3.up, 1);   
        }

        if (!stopLeftRotation && rotateLeft)
        {
            transform.Rotate(Vector3.up, -1);
        }
    }

    public void RotateLeft(){
        if (!stopLeftRotation)
        {
            rotateLeft = true;
        }
    }

    public void RotateRight(){
        if (!stopRightRotation)
        {
            rotateRight = true;
        }
    }

    public void StopRotation(){
        Debug.Log("Stop Rotation");
        rotateRight = false;
        rotateLeft = false;
    }
}

