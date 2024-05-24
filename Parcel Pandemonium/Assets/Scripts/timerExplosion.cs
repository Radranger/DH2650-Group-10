using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerExplosion : MonoBehaviour
{
    public float timer = 8f; // Set the timer to 8 seconds
    // When called upon, destroy the game object after timer runs out
    public void ActivateTimer(float time)
    {
        timer = time;
        StartCoroutine(Explode());
    }

    // Destroys the game object after timer runs out
    IEnumerator Explode()
    {
        yield return new WaitForSeconds(timer);
        gameObject.GetComponent<touchPlayerAndExplode>().Explode();
    }

}
