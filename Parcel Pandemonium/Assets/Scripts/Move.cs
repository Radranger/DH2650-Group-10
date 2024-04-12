using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public Transform startPoint; // Transform of the starting point
    public Transform endPoint;   // Transform of the ending point
    public float movementSpeed = 2.0f; // Speed of movement

    public float direction = 1; // Direction of movement

    private bool movingToEnd = true; // Indicates whether the platform is moving towards the end point

    public void changeDirection(){
        direction *= -1;
    }
    // Update is called once per frame
    void Update()
    {
        // Determine the target position based on the current direction of movement
        Vector3 targetPosition = movingToEnd ? endPoint.position : startPoint.position;

        // Calculate the movement step
        float step = movementSpeed * Time.deltaTime * direction;

        // Move the platform towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        // Check if the platform has reached the target position
        if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
            // If the platform has reached the end point, switch direction
            if (movingToEnd)
            {
                movingToEnd = false;
            }
            // If the platform has reached the start point, switch direction
            else
            {
                movingToEnd = true;
            }
        }
    }
}
