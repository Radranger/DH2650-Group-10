using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followParent : MonoBehaviour
{
    // this script is used to make the object follow the parent object
    
    void Update()
    {
        // set the position of the object to the position of the parent object
        transform.localPosition = new Vector3(0, 0, -6);
        transform.localRotation = Quaternion.Euler(-90, 0, 0);
    }
}
