using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSoundsVolume : MonoBehaviour {

public Slider soundSlider;
public AudioSource soundSource;

public Text soundText;
	// Use this for initialization
	
	void Awake()
	{
		if(PlayerPrefs.GetFloat("SoundVolume")!=0)
		{
			soundSlider.value = PlayerPrefs.GetFloat("SoundVolume");
		}
		else
		{
			soundSlider.value = 0.4f;
		}
	}
	// Update is called once per frame
	void Update () 
	{
		soundSource.volume = soundSlider.value;
		PlayerPrefs.SetFloat("SoundVolume",soundSlider.value);
		soundText.text = soundSlider.value.ToString("0.##");
	}
}
