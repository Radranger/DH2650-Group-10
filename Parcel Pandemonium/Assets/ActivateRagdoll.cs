using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRagdoll : MonoBehaviour
{   
    public GameObject playerRig;
    // when colliding with an object, activate the ragdoll

    private void Start() {
        // Deactivate the ragdoll by disabling all Rigidbody components in the hierarchy
        Rigidbody[] ragdollRigidbodies = playerRig.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in ragdollRigidbodies)
        {
            rb.isKinematic = true;
        }
        
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Collision detected");
        // Activate the ragdoll by enabling all Rigidbody components in the hierarchy
        Rigidbody[] ragdollRigidbodies = playerRig.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in ragdollRigidbodies)
        {
            rb.isKinematic = false;
        }
    }
}
