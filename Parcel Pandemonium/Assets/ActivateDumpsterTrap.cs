using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDumpsterTrap : MonoBehaviour
{
    // When receiving a message "Activate", activates the children of the object with component Move
    public void ActivateTrap()
    {
        foreach (Transform child in transform)
        {
            Move move = child.GetComponent<Move>();
            move.ChangeDirection();
        }
    }

}
