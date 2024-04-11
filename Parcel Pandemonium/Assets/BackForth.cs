using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public Transform startPoint; // Transform of the starting point
    public Transform endPoint;   // Transform of the ending point
    public float movementSpeed = 2.0f; // Speed of movement

    private bool movingToEnd = true; // Indicates whether the platform is moving towards the end point

    void Update()
    {
        // Determine the target position based on the current direction of movement
        Vector3 targetPosition = movingToEnd ? endPoint.position : startPoint.position;

        // Calculate the movement step
        float step = movementSpeed * Time.deltaTime;

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
