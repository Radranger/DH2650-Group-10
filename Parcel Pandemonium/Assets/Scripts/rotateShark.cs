using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateShark : MonoBehaviour
{

    private Boolean isRotating = false;
    // Update is called once per frame
    public void RotateSharkOnce()
    {
        // Rotate the shark around the x axis only one circumference
        isRotating = true;
    }

    void Update()
    {
        // Rotate the shark around the x axis only one circumference
        if (isRotating)
        {
            transform.Rotate(360 * Time.deltaTime, 0, 0);
        }
        // Stop rotating the shark when it has rotated one circumference
        Debug.Log(transform.rotation.eulerAngles.x);
        if (transform.rotation.eulerAngles.x >= 355f)
        {
            Debug.Log("Shark has rotated one circumference");
            isRotating = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        
    }
}
