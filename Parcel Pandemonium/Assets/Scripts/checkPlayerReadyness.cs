using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPlayerReadyness : MonoBehaviour
{
    public bool player1Ready = false;
    public bool player2Ready = false;

    public void changePlayer1Ready()
    {
        player1Ready = !player1Ready;
    }

    public void changePlayer2Ready()
    {
        player2Ready = !player2Ready;
    }
}
