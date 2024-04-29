using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmActivation : MonoBehaviour
{
    // Runs function when called
    public void Activate()
    {
        gameObject.SendMessage("ActivateTrap");
    }
}
