using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNEW : MonoBehaviour
{
    public float sensitivity = 5f;
    float rotX;
    float rotY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotX += Input.GetTouch(0).position.x * sensitivity;
        rotY += Input.GetTouch(0).position.y * sensitivity;
        
        this.transform.rotation  = Quaternion.Euler(rotX, rotY, 0f);
    }
}
