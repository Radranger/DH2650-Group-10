using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDumpsterTrap : MonoBehaviour
{
    public GameObject[] dumpsters;
    // When receiving a message "Activate", activates the children of the object with component Move    
    public void ActivateTrap()
    {
        // for each dumpster in dumpsters
        foreach (GameObject dumpster in dumpsters)
        {
            // if the dumpster has a Move component
            if (dumpster.GetComponent<Move>())
            {
                // activate the dumpster
                dumpster.GetComponent<Move>().ChangeDirection();
            }
        }
    }

}
