using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScoreDisplay : MonoBehaviour
{
    public GameObject scoreboardPanel;
    public TextMeshProUGUI finalScoreText;

    private void Start()
    {
        if (scoreboardPanel != null)
        {
            scoreboardPanel.SetActive(false);
        }
    }

    public void DisplayFinalScore(int finalScore)
    {
        if (scoreboardPanel != null)
        {
            scoreboardPanel.SetActive(true);

            if (finalScoreText != null)
            {
                finalScoreText.text = "Final Score: " + finalScore.ToString();
            }
        }
    }
}