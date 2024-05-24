using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTimers : MonoBehaviour
{
    // activate all timers in the orbs
    public void ActivateAllTimers()
    {
        timerExplosion[] timers = FindObjectsOfType<timerExplosion>();
        foreach (timerExplosion timer in timers)
        {
        }
    }
}
