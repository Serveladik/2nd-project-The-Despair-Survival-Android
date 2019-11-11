using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSounds : MonoBehaviour {

	// Use this for initialization
	public AudioClip[] ShotClips;
	public AudioSource audio;
	public ShotAllow shootFlag;
	public FireButtonScript fireButton;
	// Update is called once per frame

	

	void Update () 
	{
		if(shootFlag.shoot == true)
		{
			if(fireButton.fireButton==true)
			{
				audio.clip = ShotClips[0];
				audio.PlayOneShot(audio.clip);
			}
		}
	}
}
