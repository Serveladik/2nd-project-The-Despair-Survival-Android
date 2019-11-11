using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunButton : MonoBehaviour
{
  public bool RunPressed=false;
  public float holdTime;
    // Start is called before the first frame update
    public FirstPersonControllerFix movement;
  public void OnPointerDown()
  {
    RunPressed=true;
    StartCoroutine("RunBtn");
    
  }
  public void OnPointerUp()
  {
    RunPressed=false;
    movement.m_WalkSpeed = 0f;
    movement.m_IsWalking=false;
  }
 
 public IEnumerator RunBtn()
 {
   if(RunPressed==true)
   {
      movement.m_WalkSpeed = 16f;
      yield return new WaitForSeconds(Time.deltaTime);
   }
 
 }
}
