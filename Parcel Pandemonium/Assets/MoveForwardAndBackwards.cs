using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardAndBackwards : MonoBehaviour
{   
    public float speed = 10.0f;
  
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
