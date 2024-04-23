using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RespawnDriver : MonoBehaviour
{
    public float respawnTime = 5.0f;
    public GameObject playerRig;
    public GameObject hips;
    public GameObject veichle;

    // respawn the player after a certain amount of time
    public void Respawn(Vector3[] currentPositions, Vector3[] currentRotations)
    {
        StartCoroutine(RespawnCoroutine(currentPositions, currentRotations));
    }
    private IEnumerator RespawnCoroutine(Vector3[] currentPositions, Vector3[] currentRotations)
    {
        yield return new WaitForSeconds(respawnTime);
        Rigidbody[] ragdollRigidbodies = playerRig.GetComponentsInChildren<Rigidbody>();
        for (int i = 0; i < ragdollRigidbodies.Length; i++)
        {   
            ragdollRigidbodies[i].isKinematic = true;
            ragdollRigidbodies[i].transform.position = currentPositions[i];
            ragdollRigidbodies[i].transform.rotation = Quaternion.Euler(currentRotations[i]);
        }
        gameObject.GetComponent<PlayerMovement>().enabled = true;
        // set player position to center of game object
        Vector3 deathPosition = hips.transform.position;
        gameObject.transform.position = new Vector3(deathPosition.x, 4, deathPosition.z);
        hips.transform.localPosition = new Vector3(0f,0.642844975f,-0.0278345123f);
        hips.transform.localRotation = Quaternion.Euler(0,0,0);
        veichle.transform.localPosition = new Vector3(0f,0f,-6f);
        veichle.transform.localRotation = Quaternion.Euler(-90,0,0);
    }
}
