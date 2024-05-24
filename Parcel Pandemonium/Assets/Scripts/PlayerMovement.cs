using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 10f;
    private Vector3 initialPosition; // Store the initial position of the player

    void Start()
    {
        // Store the initial position of the player
        initialPosition = transform.position;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);

        float rotationInput = horizontalInput * speed * Time.deltaTime* rotationSpeed;
        transform.Rotate(0f, rotationInput, 0f);
    }

    // Method to reset the player position to the initial position
    public void ResetPlayerPosition()
    {
        transform.position = initialPosition;
    }
}
