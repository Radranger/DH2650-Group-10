using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteDelivery : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.DeliverPizza();
        }
    }
}
