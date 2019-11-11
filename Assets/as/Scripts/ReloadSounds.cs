using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadSounds : MonoBehaviour {

	public AudioClip[] ShotClips;
	public AudioSource audio;

	
	// Update is called once per frame

	

	void ClipDown () 
	{
		audio.clip = ShotClips[0];
		audio.PlayOneShot(audio.clip);
	}
	void ClipUp () 
	{
		audio.clip = ShotClips[1];
		audio.PlayOneShot(audio.clip);
	}
	void Shutter () 
	{
		audio.clip = ShotClips[2];
		audio.PlayOneShot(audio.clip);
	}
}

