using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrapTrigger : MonoBehaviour
{
    public GameObject ballHolder;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected");
        if (other.tag == "Player")
        {
            Destroy(ballHolder);
        }
    }

    void OnCollisionEnter(Collision other) {
        Debug.Log("Collision detected");
        if (other.gameObject.tag == "Player")
        {
            Destroy(ballHolder);
        }
    }
}
