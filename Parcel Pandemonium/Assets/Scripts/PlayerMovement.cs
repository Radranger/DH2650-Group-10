using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 10f;
    private Vector3 initialPosition; // Store the initial position of the player
    private bool isMovementEnabled = true; // Flag to enable/disable movement


    void Start()
    {
        // Store the initial position of the player
        initialPosition = transform.position;
    }

    void Update()
    {
        if (isMovementEnabled)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
            transform.Translate(movement);

            float rotationInput = horizontalInput * speed * Time.deltaTime * rotationSpeed;
            transform.Rotate(0f, rotationInput, 0f);
        }
    }

    // Method to reset the player position to the initial position
    public void ResetPlayerPosition()
    {
        transform.position = initialPosition;
    }

    // Method to disable player movement
    public void DisableMovement()
    {
        isMovementEnabled = false;
    }
}
