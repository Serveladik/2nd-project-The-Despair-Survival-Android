using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownMovement : MonoBehaviour
{
   public bool WalkPressed=false;
    public float holdTime;
    // Start is called before the first frame update
    public FirstPersonControllerFix movement;
  public void OnPointerDown()
  {
    WalkPressed=true;
    StartCoroutine("WalkBtn");
    
  }
  public void OnPointerUp()
  {
    WalkPressed=false;
    movement.m_WalkSpeed = 0f;
  }
 
 public IEnumerator WalkBtn()
 {
   while(WalkPressed==true)
   {
      
      movement.m_WalkSpeed = 10f;
      yield return new WaitForSeconds(Time.deltaTime);
   }
 }
}
