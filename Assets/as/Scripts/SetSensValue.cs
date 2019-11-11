using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class SetSensValue : MonoBehaviour {

public Slider mouseSensSlider;
public CameraScript mouseSens;
public Text musicText;
	// Use this for initialization
	
	void Awake()
	{
		if(PlayerPrefs.GetFloat("MouseSens")!=0)
		{
			mouseSensSlider.value = PlayerPrefs.GetFloat("MouseSens");
		}
		else
		{
			mouseSensSlider.value  = 5f;
			mouseSens.XSensitivity = 5f;
			mouseSens.YSensitivity = 5f;
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		mouseSens.XSensitivity = mouseSensSlider.value;
		mouseSens.YSensitivity = mouseSensSlider.value;

		PlayerPrefs.SetFloat("MouseSens",mouseSensSlider.value);
		

		musicText.text = mouseSensSlider.value.ToString("0.##");
	}
}
