using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShotScript : MonoBehaviour {
public Animator GunShotAnim;
public Animator HandsShot;


public Camera myCamera;

	// Use this for initialization
	
public GameObject bulletDecal;
public ParticleSystem flash;
public ShotAllow shootFlag;
public Animator cameraShootAnim;
public FireButtonScript fireButton;
//

	// Update is called once per frame
	void Update () 
	{
		Shoot();
		Shooting();
		UnShoot();

		
		if (this.HandsShot.GetCurrentAnimatorStateInfo(0).IsName("GunPickAnim"))
 		{
   	 		HandsShot.SetBool("Picked",true);
 		}
	}

	void Shoot()
	{
	if(fireButton.fireButton==true)
		{
			if(shootFlag.shoot == true)
			{
				GunShotAnim.SetBool("Shoot",true);	
				HandsShot.SetBool("ShootHands",true);
				HandsShot.SetBool("ShotWhileRun",true);
				cameraShootAnim.SetBool("CameraShoot",true);
				
			}
			
		}
	}

	void UnShoot()
	{
		if(fireButton.fireButton==false)
		{
			GunShotAnim.SetBool("Shoot",false);	
			HandsShot.SetBool("ShootHands",false);
			HandsShot.SetBool("ShotWhileRun",false);
			cameraShootAnim.SetBool("CameraShoot",false);
		}
	}

  void Shooting()
  {
  	RaycastHit hit;
  	if(fireButton.fireButton==true)
		{
  			if(shootFlag.shoot == true && Physics.Raycast(myCamera.transform.position, myCamera.transform.forward,out hit))
  			{
  				GameObject go = Instantiate(bulletDecal,hit.point,Quaternion.FromToRotation(Vector3.up,hit.normal));
  				go.transform.parent = hit.transform;
  			}	
		}
  }

	
	


}
