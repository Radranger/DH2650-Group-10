using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DmActivateBallTrap : MonoBehaviour
{
    public GameObject[] Orbs;
    public GameObject[] objectsToActivate;
    public GameObject[] spawnLocations;
    public float resetTime = 9f;
    public Button button;

    private bool activated = true;

    void ActivateTrap()
    {   
        if (!activated)
        {
            return;
        }
        
        // set button to disabled
        button.interactable = false;

        foreach (GameObject obj in objectsToActivate)
        {
            obj.GetComponent<Rotate120Degrees>().Rotate();
        }

        foreach (GameObject orb in Orbs)
        {   
            int orbIndex = System.Array.IndexOf(Orbs, orb);
            GameObject spawnLocation = spawnLocations[orbIndex];
            // spawn the orb as child of gameobject
            GameObject spawnedOrb = Instantiate(orb, spawnLocation.transform.position, spawnLocation.transform.rotation);
            Destroy(spawnedOrb, resetTime);

            activated = false;
            StartCoroutine(StopActivation());
        }

        timerExplosion[] timers = FindObjectsOfType<timerExplosion>();
        foreach (timerExplosion timer in timers)
        {
            timer.ActivateTimer(Random.Range(7f, 8f));
        }
    }

    IEnumerator StopActivation()
    {
        yield return new WaitForSeconds(resetTime);
        button.interactable = true;
        activated = true;
    }
}
