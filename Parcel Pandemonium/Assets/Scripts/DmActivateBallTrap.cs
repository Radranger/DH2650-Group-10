using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmActivateBallTrap : MonoBehaviour
{

    public GameObject[] objectsToActivate;
    void ActivateTrap()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            obj.GetComponent<Rotate120Degrees>().Rotate();
        }
    }
}
