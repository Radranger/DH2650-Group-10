using System.Collections;
using UnityEngine;

public class WaterCollision : MonoBehaviour
{
    private PizzaHealth pizzaHealth;

    private void Start()
    {
        // Find the PizzaHealth component in the scene
        pizzaHealth = FindObjectOfType<PizzaHealth>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is the player
        if (collision.collider.CompareTag("Player"))
        {
            // Set pizzas to 0 to indicate game over
            if (pizzaHealth != null)
            {
                pizzaHealth.pizzas = 0;
                pizzaHealth.Update(); // Update the UI immediately
            }
        }
    }
}
