using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutBounds : MonoBehaviour
{
        public Transform respawnPoint;

        private void OnTriggerEnter(Collider other)
        {
        Debug.Log("Trigger entered by: " + other.name);
            if (other.CompareTag("Player"))
            {
                Debug.Log("Player died!");
                RespawnPlayer(other.gameObject);
            }
        }

        private void RespawnPlayer(GameObject Player)
        {
            Player.transform.position = respawnPoint.position;
            Player.transform.rotation = respawnPoint.rotation;
        }
}
