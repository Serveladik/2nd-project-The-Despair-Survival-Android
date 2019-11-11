using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo_Rotation : MonoBehaviour
{
    public bool right;
    public bool left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (right)
            transform.Rotate(Vector3.up, Time.deltaTime);
        if(left)
            transform.Rotate(-Vector3.up, Time.deltaTime);
    }
}
