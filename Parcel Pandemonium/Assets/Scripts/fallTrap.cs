using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallTrap : MonoBehaviour
{
    public GameObject[] movePoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move back and forth between two points with speed of 10
        transform.position = Vector3.Lerp(movePoints[0].transform.position, movePoints[1].transform.position, Mathf.PingPong(Time.time * 0.1f, 1.0f));
}}
