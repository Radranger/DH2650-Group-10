using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateToOriginalPosition : MonoBehaviour
{
 // Variables for controlling the balancing behavior
    public float rotationSpeed = 5f; // Adjust this value to control rotation speed
    public float returnSpeed = 2f;   // Adjust this value to control how quickly the platform returns to its original position

    private Quaternion initialRotation;

    void Start()
    {
        // Store the initial rotation of the platform
        initialRotation = transform.rotation;
    }

    void Update()
    {
        // Rotate the platform back to its initial position
        transform.rotation = Quaternion.Slerp(transform.rotation, initialRotation, Time.deltaTime);

        // Stops the platform from rotation around the worlds y-axis



    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if an object has collided with the platform
        // You might want to add additional checks here to make sure it's the type of object you want to react to
        if (collision.gameObject.CompareTag("Player")) // Adjust "Player" tag to match the tag of your objects
        {
            // Rotate the platform when an object lands on it
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
