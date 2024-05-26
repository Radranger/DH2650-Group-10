using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningPoint : MonoBehaviour
{
    public AudioSource winningSound;
    public AudioSource music;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has triggered the endpoint
        if (other.CompareTag("Player"))
        {
            // Get the ScoreManager instance and call EndGame
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                music.Stop();
                winningSound.Play();
                scoreManager.EndGame();
            }
        }
    }
}
