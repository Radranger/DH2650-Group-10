using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathZone : MonoBehaviour
{
    public Vector3 spawnPoint = new Vector3(-39.0f, 3.3f, 61.2f);


    void OntriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = spawnPoint;
        }
    }

}
