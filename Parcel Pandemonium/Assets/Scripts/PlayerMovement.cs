using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float maxSpeed;
    private float currentSpeed = 0.0f;
    public float tiltAngle;
    private float reverseSpeed = 0.0f;


    void Update()
    {
        // Get input from the "W" key
        if (Input.GetKey(KeyCode.W))
        {
            // Increase currentSpeed gradually up to the maxSpeed
            currentSpeed = Mathf.Min(currentSpeed + (maxSpeed * Time.deltaTime), maxSpeed);
        }
        else
        {
            // If "W" key is not pressed, gradually decrease currentSpeed back to 0
            currentSpeed = Mathf.Max(currentSpeed - (maxSpeed * Time.deltaTime), 0.0f);
        }

        // Get input from the "W" key
        if (Input.GetKey(KeyCode.S) && currentSpeed == 0)
        {
            reverseSpeed = 2.0f;
        }
        else
        {
            reverseSpeed = 0.0f;
        }

        //tilt angle
        float tiltAmount = 0.0f;
        if (Input.GetKey(KeyCode.A))
        {
            tiltAmount = tiltAngle;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            tiltAmount = -tiltAngle;
        }

        //if speed = 0 disable rotation
        if (currentSpeed == 0.0f && reverseSpeed == 0.0f)
        {
            rotationSpeed = 0.0f;
        }
        else
        {
            rotationSpeed = 2.5f;
        }

        Quaternion targetTilt = Quaternion.Euler(0, 0, tiltAmount);
        //transform.rotation = Quaternion.Lerp(transform.rotation, targetTilt, Time.deltaTime * 5.0f);

        float horizontalInput = Input.GetAxis("Horizontal");

        float rotationInput = horizontalInput * speed * Time.deltaTime * rotationSpeed;
        transform.Rotate(0f, rotationInput, 0f);
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed);


        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        transform.Translate(Vector3.back * reverseSpeed * Time.deltaTime);

        /*float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);*/
    }
}
    
