using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour {
	//public AudioVolume1 MenuMusicScript;
	public Slider volumeSlider;
	public AudioSource soundsGame;
	public AudioSource stepsMenu;
	public AudioSource paperSound;

	public AudioSource eatZombie;
	public AudioSource roarZombie;





	// Use this for initialization
	void Start () {
		//Getting all sounds values that we were setting from menu
		soundsGame.volume =  PlayerPrefs.GetFloat ("Volume");
		paperSound.volume =  PlayerPrefs.GetFloat ("Volume");
		volumeSlider.value = PlayerPrefs.GetFloat ("Volume");
		eatZombie.volume   = PlayerPrefs.GetFloat ("Volume");
		roarZombie.volume =  PlayerPrefs.GetFloat ("Volume");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		//Changing sounds volume with the slider
		soundsGame.volume = volumeSlider.value;
		stepsMenu.volume = volumeSlider.value;
		paperSound.volume = volumeSlider.value;
		eatZombie.volume = volumeSlider.value;
		roarZombie.volume = volumeSlider.value;

	}
}
