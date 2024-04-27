using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmActivateFallTrap : MonoBehaviour
{
    public GameObject thrower;
    public void ActivateTrap()
    {
        thrower.GetComponent<ThrowObject>().Throw();
    }
}
