using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoBox : MonoBehaviour {
public int bulletInBox;
public BulletsScipt bltScript;

public Text ammoText;
public Text ammoPickedText;
public Animator ammoTextAnim;

public bool pickupFlag=false;
	// Use this for initialization
	void Update()
	{
		PickUpAmmo();
	}

	void PickUpAmmo()
	{
		if(pickupFlag==true)
		{
			if(Input.GetKeyDown(KeyCode.E))
			{
				bltScript.BulletsLeft+=bulletInBox;
				ammoPickedText.enabled = true;
				ammoPickedText.text = "Picked ammo: +"+ bulletInBox;
				ammoTextAnim.SetBool("PickedUp",true);
		
				Destroy(this.gameObject);
				ammoText.enabled=false;
		 	}
			 if (this.ammoTextAnim.GetCurrentAnimatorStateInfo(0).IsName("AmmoTextAnim"))
 			{
				ammoPickedText.enabled = false;
				ammoTextAnim.SetBool("PickedUp",false);
			}
		}
		
	}
	
	// Update is called once per frame
 public void OnTriggerEnter(Collider player)
 {
	 if(player.gameObject.tag == "Main_Player")
	 {
	 	ammoText.enabled=true;
		pickupFlag = true;
	 }
 }
 public void OnTriggerExit(Collider player)
 {
	 if(player.gameObject.tag == "Main_Player")
	 {
	 	ammoText.enabled=false;
		pickupFlag = false;
	 }
 }

}
