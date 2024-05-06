using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRagdoll : MonoBehaviour
{   
    public GameObject playerRig;
    private Vector3[] currentPositions;
    private Vector3[] currentRotations;
    private Rigidbody[] ragdollRigidbodies;
    // when colliding with an object, activate the ragdoll

    private void Start() {
        // Deactivate the ragdoll by disabling all Rigidbody components in the hierarchy
        ragdollRigidbodies = playerRig.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in ragdollRigidbodies)
        {
            rb.isKinematic = true;
        }
        // Initiate position and rotation of each part of the ragdoll
        currentPositions = new Vector3[ragdollRigidbodies.Length];
        currentRotations = new Vector3[ragdollRigidbodies.Length];


    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Collision detected");
        ragdollRigidbodies = playerRig.GetComponentsInChildren<Rigidbody>();
        for (int i = 0; i < ragdollRigidbodies.Length; i++)
        {
            currentPositions[i] = ragdollRigidbodies[i].transform.position;
            currentRotations[i] = ragdollRigidbodies[i].transform.rotation.eulerAngles;
        }
        // Activate the ragdoll by enabling all Rigidbody components in the hierarchy
        foreach (Rigidbody rb in ragdollRigidbodies)
        {
            rb.isKinematic = false;
            gameObject.GetComponent<PlayerMovement>().enabled = false;
        }
        gameObject.GetComponent<RespawnDriver>().Respawn(currentPositions, currentRotations);
    }
}
