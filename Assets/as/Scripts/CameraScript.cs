using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
   private Vector3 firstpoint; //change type on Vector3
  private Vector3 secondpoint;
  private float xAngle  = 0.0f; //angle for axes x for rotation
  private float yAngle  = 0.0f;
  private float xAngTemp = 0.0f; //temp variable for angle
  private float yAngTemp = 0.0f;
  public float XSensitivity=2f;
  public float YSensitivity=2f;
  public CameraZone cameraZone;
  public NoTouchZone noTouchZone;
  public RunButton runBool;
  public UpDownMovement fwdBool;
  public UpDownMovement backBool;
  public LeftRightMovement rightBool;
  public LeftRightMovement leftBool;

  
  void Awake() 
  {
   //Initialization our angles of camera

   this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
   XSensitivity = PlayerPrefs.GetFloat("MouseSens");
   YSensitivity = PlayerPrefs.GetFloat("MouseSens");
  }
  void IsOnCameraPanel() 
  { 
    if(noTouchZone.isOnCameraPanel == false & runBool.RunPressed==false & backBool.WalkPressed==false & fwdBool.WalkPressed==false & leftBool.WalkPressed==false & rightBool.WalkPressed==false & cameraZone.isOnCameraPanel==true) 
{ 
    if(Input.GetTouch(0).phase == TouchPhase.Began )  
    { 
     firstpoint = Input.GetTouch(0).position; 
     xAngTemp = xAngle; 
     yAngTemp = yAngle; 
    } 
     
      if(Input.GetTouch(0).phase==TouchPhase.Moved)  
      { 
       secondpoint = Input.GetTouch(0).position; 
       //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree 
       xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 30 * XSensitivity / Screen.width; 
       yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 15 * YSensitivity / Screen.height; 
       //Rotate camera 
       yAngle = Mathf.Clamp(yAngle, -50f, 50f); 
       this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f); 
      } 
} 
if(noTouchZone.isOnCameraPanel == true & cameraZone.isOnCameraPanel==true) 
{ 
if(Input.GetTouch(1).phase == TouchPhase.Began)  
    { 
     firstpoint = Input.GetTouch(1).position; 
     xAngTemp = xAngle; 
     yAngTemp = yAngle;    
    } 
      if(Input.GetTouch(1).phase==TouchPhase.Moved)  
      { 
       secondpoint = Input.GetTouch(1).position; 
       //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree 
       xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 30 * XSensitivity / Screen.width; 
       yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 15 * YSensitivity / Screen.height; 
       //Rotate camera 
       yAngle = Mathf.Clamp(yAngle, -50f, 50f); 
       this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f); 
      } 
    } 
    /////////////////////////////////////// 
if(runBool.RunPressed==true & cameraZone.isOnCameraPanel==true) 
{ 
if(Input.GetTouch(1).phase == TouchPhase.Began)  
    { 
     firstpoint = Input.GetTouch(1).position; 
     xAngTemp = xAngle; 
     yAngTemp = yAngle; 
    } 
      if(Input.GetTouch(1).phase==TouchPhase.Moved)  
      { 
       secondpoint = Input.GetTouch(1).position; 
       //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree 
       xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 30 * XSensitivity / Screen.width; 
       yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 15 * YSensitivity / Screen.height; 
       //Rotate camera 
       yAngle = Mathf.Clamp(yAngle, -50f, 50f); 
       this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f); 
      } 
    } 
    /////////////////////////////////////// 
if(backBool.WalkPressed==true & cameraZone.isOnCameraPanel==true) 
{ 
if(Input.GetTouch(1).phase == TouchPhase.Began)  
    { 
     firstpoint = Input.GetTouch(1).position; 
     xAngTemp = xAngle; 
     yAngTemp = yAngle;  
    } 
      if(Input.GetTouch(1).phase==TouchPhase.Moved)  
      { 
       secondpoint = Input.GetTouch(1).position; 
       //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree 
       xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 30 * XSensitivity / Screen.width; 
       yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 15 * YSensitivity / Screen.height; 
       //Rotate camera 
       yAngle = Mathf.Clamp(yAngle, -50f, 50f); 
       this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f); 
      } 
    } 
    ////////////////////////////////////// 
if(fwdBool.WalkPressed==true & cameraZone.isOnCameraPanel==true) 
{ 
if(Input.GetTouch(1).phase == TouchPhase.Began)  
    { 
     firstpoint = Input.GetTouch(1).position; 
     xAngTemp = xAngle; 
     yAngTemp = yAngle;  
    } 
      if(Input.GetTouch(1).phase==TouchPhase.Moved)  
      { 
       secondpoint = Input.GetTouch(1).position; 
       //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree 
       xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 30 * XSensitivity / Screen.width; 
       yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 15 * YSensitivity / Screen.height; 
       //Rotate camera 
       yAngle = Mathf.Clamp(yAngle, -50f, 50f); 
       this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f); 
      } 
    } 
    /////////////////////////////////////// 
if(leftBool.WalkPressed==true & cameraZone.isOnCameraPanel==true) 
{ 
if(Input.GetTouch(1).phase == TouchPhase.Began)  
    { 
     firstpoint = Input.GetTouch(1).position; 
     xAngTemp = xAngle; 
     yAngTemp = yAngle; 
    } 
      if(Input.GetTouch(1).phase==TouchPhase.Moved)  
      { 
       secondpoint = Input.GetTouch(1).position; 
       //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree 
       xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 30 * XSensitivity / Screen.width; 
       yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 15 * YSensitivity / Screen.height; 
       //Rotate camera 
       yAngle = Mathf.Clamp(yAngle, -50f, 50f); 
       this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f); 
      } 
    } 
    ///////////////////////////////////// 
if(rightBool.WalkPressed==true & cameraZone.isOnCameraPanel==true) 
{ 
if(Input.GetTouch(1).phase == TouchPhase.Began)  
    { 
     firstpoint = Input.GetTouch(1).position; 
     xAngTemp = xAngle; 
     yAngTemp = yAngle; 
    } 
      if(Input.GetTouch(1).phase==TouchPhase.Moved)  
      { 
       secondpoint = Input.GetTouch(1).position; 
       //Mainly, about rotate camera. For example, for Screen.width rotate on 180 degree 
       xAngle = xAngTemp + (secondpoint.x - firstpoint.x) * 30 * XSensitivity / Screen.width; 
       yAngle = yAngTemp - (secondpoint.y - firstpoint.y) * 15 * YSensitivity / Screen.height; 
       //Rotate camera 
       yAngle = Mathf.Clamp(yAngle, -50f, 50f); 
       this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f); 
      } 
    } 
  } 
  
   



  
  void Update() 
  {
   IsOnCameraPanel();
   //NoTouchZone();
  }
  

   
}                                              //The key point is use localRotation,not rotation or Quaternion.Rotate.
     

