using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool fireButton=false;
    
    public void OnPointerDown()
    {
        fireButton=true;
        
    }
    public void OnPointerUp()
    {
        fireButton=false;
    }
}
