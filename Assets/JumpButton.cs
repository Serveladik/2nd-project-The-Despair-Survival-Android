using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    public FirstPersonControllerFix fpsControl;
    // Start is called before the first frame update
    

    // Update is called once per frame
   public void Jump()
   {
       fpsControl.jumpPressed=true;
   }
   public void noJump()
   {
       fpsControl.jumpPressed=false;
   }
}
