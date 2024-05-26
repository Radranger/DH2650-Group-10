using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMCameraControll : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCamera = 0;

    public void ChangeCameraRight(){
        if(currentCamera == cameras.Length - 1){
            currentCamera = 0;
        }else{
            currentCamera++;
        }

        //change camera
        for (int i = 0; i < cameras.Length; i++)
        {
            if (i == currentCamera)
            {
                cameras[i].enabled = true;
            }
            else
            {
                cameras[i].enabled = false;
            }
        }
    }

    public void ChangeCameraLeft(){
        if(currentCamera == 0){
            currentCamera = cameras.Length - 1;
        }else{
            currentCamera--;
        }

        //change camera
        for (int i = 0; i < cameras.Length; i++)
        {
            if (i == currentCamera)
            {
                cameras[i].enabled = true;
            }
            else
            {
                cameras[i].enabled = false;
            }
        }
    }
}
