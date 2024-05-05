using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutBounds : MonoBehaviour
{
        public Transform player;
        public Transform respawnPoint;

        private float cameraDistanceX = 0f; 
        private float cameraDistanceY = 1.48f; 
        private float cameraDistanceZ = -3.61f; 


    private Rigidbody playerRigidbody; 

    private void Start()
    {
        playerRigidbody = player.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
            player.transform.rotation = respawnPoint.transform.rotation;

            Transform playerTransform = player.Find("Vehicle01_Vespa"); 
            if (playerTransform != null)
            {
                playerTransform.localPosition = Vector3.zero;
                playerTransform.localRotation = Quaternion.Euler(270f, 0f, 0f); 
            }
        
            Transform cameraTransform = player.Find("Camera (1)"); 
            if (cameraTransform != null)
            {
                cameraTransform.localPosition = new Vector3(cameraDistanceX, cameraDistanceY, cameraDistanceZ);
                cameraTransform.localRotation = Quaternion.Euler(new Vector3(8f, 0f, 0f));
            }

            if (playerRigidbody != null)
            {
                playerRigidbody.velocity = Vector3.zero;
                playerRigidbody.angularVelocity = Vector3.zero;
            }
        }
    }

}
