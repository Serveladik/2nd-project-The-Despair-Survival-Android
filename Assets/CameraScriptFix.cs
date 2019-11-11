using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScriptFix : MonoBehaviour
{
    private Touch initTouch = new Touch();
    public GameObject camera;

    public float rotX=0f;
    public float rotY=0f;
    private Vector3 firstTouchRot;
    public float XSensitivity;
    public float YSensitivity;
    public float dir = -1;
    // Start is called before the first frame update
    void Start()
    {
        firstTouchRot = camera.transform.eulerAngles;
        rotX = firstTouchRot.x;
        rotY = firstTouchRot.y;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began)
            {
                initTouch=touch;
            }
            else if(touch.phase == TouchPhase.Moved)
            {
                float deltaX = initTouch.position.x - touch.position.x;
                float deltaY = initTouch.position.y - touch.position.y;
                rotX +=deltaX * Time.deltaTime * XSensitivity/20 * dir;
                rotY -=deltaY * Time.deltaTime * YSensitivity/15 * dir;
                camera.transform.eulerAngles = new Vector3(rotY,rotX,0);
            }
            else if(touch.phase == TouchPhase.Ended)
            {
                initTouch = new Touch();
            }
        }
    }
}
