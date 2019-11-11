using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodShotParticleScript : MonoBehaviour {
public FireButtonScript fireButton;
public GameObject bloodParticle;
public GameObject woodParticle;
public GameObject myCamera;
public BulletsScipt bletScript;
public ShotAllow shootScript;
public float weaponDamages = 30f;
//public BoxHp boxHealth;
RaycastHit hitBox;
	// Update is called once per frame
	void Update () 
	{
		WoodImpactParticle();
		//Debug.DrawRay(myCamera.transform.position, myCamera.transform.forward * 2.3f);
	}

	void WoodImpactParticle()
	{
		if(fireButton.fireButton==true)
		{
			if(shootScript.shoot == true)
			{
				if(bletScript.BulletsInClip>0)
				{
					if(Physics.Raycast(myCamera.transform.position, myCamera.transform.forward,out hitBox) && hitBox.transform.tag == "Box")
  					{
						hitBox.transform.SendMessageUpwards("BoxHealth", weaponDamages);
  						Instantiate(woodParticle,hitBox.point,Quaternion.FromToRotation(myCamera.transform.forward,hitBox.normal));
  					}	

					if(Physics.Raycast(myCamera.transform.position, myCamera.transform.forward,out hitBox) && hitBox.transform.tag == "ZombieTag")
  					{
						Debug.Log("Body");
						weaponDamages = 30f;
						hitBox.transform.SendMessageUpwards("ZombieHealth", weaponDamages);
						//Blood particles
  						Instantiate(bloodParticle,hitBox.point,Quaternion.FromToRotation(myCamera.transform.forward,hitBox.normal));
  					}	

					if(Physics.Raycast(myCamera.transform.position, myCamera.transform.forward,out hitBox) && hitBox.transform.tag == "ZombieHeadTag")
  					{
						Debug.Log("HEAD");
						weaponDamages = 60f;
						hitBox.transform.SendMessageUpwards("ZombieHealth", weaponDamages);
						//Blood particles
  						Instantiate(bloodParticle,hitBox.point,Quaternion.FromToRotation(myCamera.transform.forward,hitBox.normal));
  					}	
				}
			}
		}
	}
}
