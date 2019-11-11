using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZone : MonoBehaviour
{
    public bool isOnCameraPanel;
    // Start is called before the first frame update
    void Start()
    {
       isOnCameraPanel=false; 
    }

    public void OnPointerDown()
    {
        isOnCameraPanel=true;
    }
    public void OnPointerUp()
    {
        isOnCameraPanel=false;
    }
}
