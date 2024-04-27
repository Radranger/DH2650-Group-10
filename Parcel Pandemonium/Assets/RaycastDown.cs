using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDown : MonoBehaviour
{
    public GameObject followObject; // Object to follow
    public float offset = 2.0f; // Speed of movement
    // place object on the ground
    void Update()
    {
        RaycastHit hit;
        // Raycast to the ground but still follow the object
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 100))
        {
            transform.position = new Vector3(followObject.transform.position.x, hit.point.y+offset, followObject.transform.position.z);
        }

    }
}
