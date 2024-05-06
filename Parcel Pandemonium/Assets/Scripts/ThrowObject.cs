using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    public float throwForce = 10f;
    private GameObject throwableObject;
    public float respawnTime = 5.0f;
    private bool isThrown = false;

    void Start()
    {
        throwableObject = transform.GetChild(0).gameObject;
    }
    void Update()
    {
        // Keeps the gameObject from rotating
        throwableObject.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void Throw()
    {
        // Stops the player from throwing the object multiple times
        if (isThrown)
        {
            return;
        }
        gameObject.GetComponent<Move>().enabled = false;
        isThrown = true;
        Debug.Log("Throwing object");
        throwableObject.GetComponent<Rigidbody>().isKinematic = false;
        throwableObject.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
        throwableObject.transform.GetChild(0).GetComponent<Rigidbody>().AddTorque(transform.right * throwForce, ForceMode.VelocityChange);
        StartCoroutine(RespawnCoroutine(respawnTime));
    }

    private IEnumerator RespawnCoroutine(float respawnTime)
    {
        yield return new WaitForSeconds(respawnTime);
        throwableObject.transform.position = transform.position;
        throwableObject.GetComponent<Rigidbody>().isKinematic = true;
        throwableObject.transform.GetChild(0).GetComponent<Rigidbody>().rotation = Quaternion.Euler(0, 0, 0);
        throwableObject.transform.GetChild(0).GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        throwableObject.transform.GetChild(1).transform.localPosition = new Vector3(0, -2, 0);
        gameObject.GetComponent<Move>().enabled = true;
        isThrown = false;
        
    }
}

