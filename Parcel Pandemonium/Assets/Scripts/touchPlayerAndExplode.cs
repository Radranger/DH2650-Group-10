using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchPlayerAndExplode : MonoBehaviour
{
    public GameObject explosionEffect;
    public AudioSource explosionSound;

    public float explosionForce = 700f;
    public float explosionRadius = 15f;
    // when colliding with player, destroy the game object
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {   
            Explode();
        }
    }

    // creates an explosion effect when colliding with player
    public void Explode()
    {   
        GameObject explosion = Instantiate(explosionEffect, transform.position, transform.rotation);
        explosionSound.Play();
        Destroy(explosion, 3f);
        Destroy(gameObject);

        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            Debug.Log(nearbyObject.tag);
            if (rb != null && nearbyObject.tag != "orb")
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
        }
    }
}
