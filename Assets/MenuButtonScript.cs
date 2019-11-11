using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonScript : MonoBehaviour
{
    public bool MenuButtonScript1=false;
    // Start is called before the first frame update
    public void OnPointerUp()
    {
        MenuButtonScript1=true;
    }
}
