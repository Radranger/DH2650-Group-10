using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScoreDisplay : MonoBehaviour
{
    public GameObject scoreboardPanel;
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI finalScoreTextDM;

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
                finalScoreText.text = "Player Score: " + finalScore.ToString();
                finalScoreTextDM.text = "DM Score: " + (100 - finalScore).ToString();
            }
        }
    }
}