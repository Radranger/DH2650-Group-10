using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerActivateFunction : MonoBehaviour
{
    public GameObject[] objectsToActivate;

    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == "Player")
        {
            foreach (GameObject obj in objectsToActivate)
            {
                obj.GetComponent<Rotate120Degrees>().Rotate();
            }
        }
    }
    
}
