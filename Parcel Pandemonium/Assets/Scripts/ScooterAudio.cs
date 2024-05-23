using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScooterAudio : MonoBehaviour
{
    private AudioSource AS;

    public float minSpeed;
    public float maxSpeed;
    private float currentSpeed;

    public float minPitch;
    public float maxPitch;
    private float scooterPitch;

    void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        ScooterSound(verticalInput);
    }

    void ScooterSound(float input)
    {
        currentSpeed = input;
        scooterPitch = currentSpeed / 2f;

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
