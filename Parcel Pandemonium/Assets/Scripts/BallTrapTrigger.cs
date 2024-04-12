using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrapTrigger : MonoBehaviour
{
    public GameObject ballHolder;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(ballHolder);
        }
    }
}
