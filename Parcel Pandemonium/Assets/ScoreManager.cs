using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int playerScore;
    public int pizzaTemperature = 100; // Start with hot pizza att 100
    public float timeElapsed = 0f;
    public float temperatureUpdateTime = 1f; // Update temperature every 1 seconds

    public Text scoreText;
    public Text temperatureText;
    public int totalPizzas;
    private int pizzasDelivered = 0;
    private bool isGameOver = false;

    public FinalScoreDisplay finalScoreDisplay;

    private void Update()
    {

        if (!isGameOver)
        {
            // Update the time elapsed
            timeElapsed += Time.deltaTime;

        // Update the pizza temperature
        if (pizzaTemperature > 0 && timeElapsed >= temperatureUpdateTime)
        {
            pizzaTemperature -= 1;

            /*if (pizzaTemperature < 0)
            {
                pizzaTemperature = 100;
            }*/

            timeElapsed = 0f;
        }

        UpdateUIText();
        }
    }

    public void DeliverPizza()
    {
        int temperaturePoints = GetTemperaturePoints();

        playerScore += 10;
        playerScore += temperaturePoints;
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

    private int GetTemperaturePoints()
    {
        if (pizzaTemperature >= 80)
        {
            // Hot pizza
            return 10; 
        }
        else if (pizzaTemperature >= 50)
        {
            // Warm pizza
            return 5; 
        }
        else
        {
            // Cold pizza
            return 1; 
        }
    }

    private void UpdateUIText()
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

}

