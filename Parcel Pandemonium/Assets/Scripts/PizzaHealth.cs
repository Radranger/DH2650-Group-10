using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizzaHealth : MonoBehaviour
{
    public int pizzas;
    public int maxpizzas;

    public AudioSource gameOverSound;
    public AudioSource music;

    public Sprite emptyPizza;
    public Sprite fullPizza;
    public Image[] pizzaStack;
    private bool hasCollided = false; // Flag to track if collision has occurred
    public bool isGameOver = false;

    public PlayerMovement playerMovement;
    public Vector3 initialPlayerPosition; // Initial position of the player

    // Reference to the ScoreManager script
    public ScoreManager scoreManager;
    public GameOver gameOver; // Reference to the GameOver script


    private void Start()
    {
        // Store the initial player position
        initialPlayerPosition = playerMovement.transform.position;

        // Find ScoreManager in the scene
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    public void Update()
    {
        for (int i = 0; i < pizzaStack.Length; i++)
        {

            if (i < pizzas)
            {
                pizzaStack[i].sprite = fullPizza;
            }
            else
            {
                pizzaStack[i].sprite = emptyPizza;
            }

            if (i < maxpizzas)
            {
                pizzaStack[i].enabled = true;
            }
            else
            {
                pizzaStack[i].enabled = false;
            }
        }

        // Check if the game is over
        if (pizzas <= 0 && !isGameOver)
        {
            isGameOver = true;
            if (scoreManager != null)
            {
                scoreManager.playerScore = 0;
                scoreManager.UpdateUIText();
            }
            StartCoroutine(RestartGame());
        }
    }

    public void TakeDamage(int amount)
    {
        if (hasCollided)
            return;

        pizzas -= amount;

        // Deduct points from the score directly in PizzaHealth
        if (scoreManager != null)
        {
            scoreManager.playerScore -= 10;

            if (scoreManager.playerScore < 0)
            {
                scoreManager.playerScore = 0; // Ensure the score doesn't go below 0
            }

            scoreManager.UpdateUIText();
        }

        if (pizzas <= 0)
        {
            playerMovement.enabled = false;
        }
        hasCollided = true;
    }

    public void ResetCollisionFlag()
    {
        hasCollided = false;
    }

    private IEnumerator RestartGame()
    {
        if (gameOver != null)
        {
            music.Stop();
            gameOverSound.Play();
            gameOver.Setup(); // Show game over screen
        }

        yield return new WaitForSeconds(10); // Wait for 5 seconds before restarting

         if (gameOver != null)
        {
            gameOver.Hide(); // Hide game over screen
        }

        // Reset the game state
        pizzas = maxpizzas;
        isGameOver = false;
        playerMovement.enabled = true;
        playerMovement.transform.position = initialPlayerPosition; // Reset player position
      
        // Reset collision flag
        ResetCollisionFlag();

        // Reset score and temperature in ScoreManager
        if (scoreManager != null)
        {
            scoreManager.ResetGame();
        }
    }
}