using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotAllow : MonoBehaviour {

	// Use this for initialization
	public bool shoot;
	
	// Update is called once per frame
	
	void ShootAllowness()
	{
		shoot=true;
		
	}
	void ShootDeniedness()
	{
		shoot=false;
		
	}
}
