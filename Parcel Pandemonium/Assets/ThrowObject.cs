using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    public float throwForce = 40f;
    private GameObject throwableObject;
    public float respawnTime = 5.0f;
    private bool isThrown = false;

    void Start()
    {
        throwableObject = transform.GetChild(0).gameObject;
    }

    public void Throw()
    {
        if (isThrown)
        {
            return;
        }
        isThrown = true;
        Debug.Log("Throwing object");
        throwableObject.GetComponent<Rigidbody>().isKinematic = false;
        throwableObject.transform.GetChild(0).gameObject.GetComponent<Rigidbody>().isKinematic = false;
         throwableObject.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
        // Add some rotation to the object
         throwableObject.transform.GetChild(0).gameObject.GetComponent<Rigidbody>().AddTorque(new Vector3(0, 0, 10), ForceMode.VelocityChange);
        
        StartCoroutine(RespawnCoroutine(respawnTime));
    }

    private IEnumerator RespawnCoroutine(float respawnTime)
    {
        yield return new WaitForSeconds(respawnTime);
        throwableObject.transform.position = transform.position;
        throwableObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        throwableObject.GetComponent<Rigidbody>().isKinematic = true;
        throwableObject.transform.GetChild(0).gameObject.GetComponent<Rigidbody>().isKinematic = true;

        isThrown = false;
        
    }
}

