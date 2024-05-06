using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScooterAudio : MonoBehaviour
{
    private AudioSource AS;
    private Rigidbody RB;

    public float minSpeed;
    public float maxSpeed;
    private float currentSpeed;

    public float minPitch;
    public float maxPitch;
    private float scooterPitch;

    void Start()
    {
        AS = GetComponent<AudioSource>();
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ScooterSound();
    }

    void ScooterSound()
    {
        currentSpeed = RB.velocity.magnitude;
        scooterPitch = RB.velocity.magnitude / 5f;

        if(currentSpeed < minSpeed){
            AS.pitch = minPitch;
        }
        if(currentSpeed > minSpeed && currentSpeed < maxSpeed){
            AS.pitch = minPitch + scooterPitch;
        }
        if(currentSpeed > maxSpeed){
            AS.pitch = maxPitch;
        }
    }
}
