using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate120Degrees : MonoBehaviour
{
    public bool rotateClockwiseOrCounterClockwise = true;
    private bool startRotating = false;
    public void Rotate()
    {
        startRotating = true;
    }

    // Rotates 120 slowly, stops after 120 degrees
    void Update()
    {
        if (startRotating)
        {
            if (rotateClockwiseOrCounterClockwise)
            {
                transform.Rotate(Vector3.up, 1);
            }
            else
            {
                transform.Rotate(Vector3.up, -1);
            }
            if (rotateClockwiseOrCounterClockwise && transform.localRotation.eulerAngles.y >= 120)
            {
                startRotating = false;
            }
            else if (!rotateClockwiseOrCounterClockwise && transform.localRotation.eulerAngles.y <= 50)
            {
                startRotating = false;
            }
            
        }
    }
}
