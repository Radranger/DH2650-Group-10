using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int playerScore;
    public int pizzaTemperature = 80; // Start with hot pizza at 80
    private int previousTemperature;
    public float timeElapsed;
    public int gameTime;
    public float temperatureUpdateTime; // Update temperature

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI temperatureText;
    public int totalPizzas;
    private int pizzasDelivered = 0;
    private bool isGameOver = false;

    public FinalScoreDisplay finalScoreDisplay;

    private void Start()
    {
        previousTemperature = pizzaTemperature;
        temperatureUpdateTime = (gameTime / pizzaTemperature);
        UpdateUIText();
    }

    private void Update()
    {
        if (!isGameOver)
        {
            // Update the time elapsed
            timeElapsed += Time.deltaTime;

            // Update the pizza temperature
            if (timeElapsed >= temperatureUpdateTime)
            {
                if (pizzaTemperature > 0)
                {
                    pizzaTemperature -= 1;
                }

                // Adjust score based on temperature change
                AdjustScoreForTemperatureChange();

                timeElapsed = 0f;
                UpdateUIText();
            }
        }
    }

    public void DeliverPizza()
    {
        playerScore += 10;
        pizzasDelivered++;

        UpdateUIText();

        if (pizzasDelivered >= totalPizzas)
        {
            isGameOver = true;

            if (finalScoreDisplay != null)
            {
                finalScoreDisplay.DisplayFinalScore(playerScore);
            }
        }
    }

    private void AdjustScoreForTemperatureChange()
    {
        int temperaturePoints = GetTemperaturePoints(pizzaTemperature);
        int previousTemperaturePoints = GetTemperaturePoints(previousTemperature);

        // Update the score based on the change in temperature points
        playerScore += (temperaturePoints - previousTemperaturePoints);

        // Update previous temperature
        previousTemperature = pizzaTemperature;
    }

    private int GetTemperaturePoints(int temperature)
    {
        if (temperature >= 50)
        {
            // Hot pizza
            return 0;
        }
        else if (temperature >= 25)
        {
            // Warm pizza
            return -10;
        }
        else
        {
            // Cold pizza
            return -20;
        }
    }

    public void UpdateUIText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + playerScore.ToString();
        }

        if (temperatureText != null)
        {
            temperatureText.text = "Temperature: " + pizzaTemperature.ToString() + "°C";
        }
    }

    public void ResetGame()
    {
        playerScore = 100; // Reset score to initial state
        pizzaTemperature = 80; // Reset temperature to initial state
        previousTemperature = pizzaTemperature; // Reset previous temperature
        UpdateUIText();
    }

    public void EndGame()
    {
        isGameOver = true;
        if (finalScoreDisplay != null)
        {
            finalScoreDisplay.DisplayFinalScore(playerScore);
        }

        // Disable player movement
        PlayerMovement playerMovement = FindObjectOfType<PlayerMovement>();
        if (playerMovement != null)
        {
            playerMovement.DisableMovement();
        }
    }
}