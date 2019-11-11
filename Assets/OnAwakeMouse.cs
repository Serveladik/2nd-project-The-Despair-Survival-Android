using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnAwakeMouse : MonoBehaviour
{
public Slider mouseSensSlider;
public CameraScript mouseSens;
    void Awake () 
	{
    // Start is called before the first frame update
    if(PlayerPrefs.GetFloat("MouseSens")!=0)
		{
			mouseSensSlider.value = PlayerPrefs.GetFloat("MouseSens");
		}
		else
		{
			PlayerPrefs.SetFloat("MouseSens",5f);
			mouseSens.XSensitivity = 5f;
			mouseSens.YSensitivity = 5f;
		}
    }
}
