using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadButton : MonoBehaviour
{
    // Start is called before the first frame update
    public bool ReloadPressed=false;
    public float holdTime;
    // Start is called before the first frame update
    public BulletsScipt movement;
  public void OnPointerDown()
  {
    ReloadPressed=true;
    StartCoroutine("ReloadBtn");
    
  }
   public void OnPointerUp()
  {
    ReloadPressed=false;
    StartCoroutine("ReloadBtn");
    
  }

 
 public IEnumerator ReloadBtn()
 {
   while(ReloadPressed==true)
   {

      yield return new WaitForSeconds(Time.deltaTime);
   }
 }
}
