using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFlash : MonoBehaviour {
public ParticleSystem flash;
public ShotAllow shootFlag;
	// Use this for initialization
	public void MuzzleFlash()
	{
		flash.Play();
	}
}
