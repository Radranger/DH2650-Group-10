using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public Transform startPoint; // Transform of the starting point
    public Transform endPoint;   // Transform of the ending point
    public float movementSpeed = 2.0f; // Speed of movement

    private bool direction = true; // Direction of movement

    public void ChangeDirection(){
        direction = !direction;
    }
    // Update is called once per frame
    void Update()
    {
        // Moves the platform between the start and end points based on diraction
        if (direction)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, movementSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPoint.position, movementSpeed * Time.deltaTime);
        }

        // Changes direction when reaching the end point
        if (transform.position == endPoint.position || transform.position == startPoint.position)
        {
            direction = !direction;
        }


    }
}
