using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has triggered the endpoint
        if (other.CompareTag("Player"))
        {
            // Get the ScoreManager instance and call EndGame
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.EndGame();
            }
        }
    }
}
