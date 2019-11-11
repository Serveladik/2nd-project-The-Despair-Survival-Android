using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class ReloadInRun : MonoBehaviour {

public ReloadButton reload;
public Animator reloadAnim;
public FirstPersonControllerFix moveScript;
	
	void Update () 
	{
		
		if(moveScript.m_IsWalking==false && reload.ReloadPressed==true)
		{
			reloadAnim.SetBool("ReloadInRun",true);
			moveScript.m_IsWalking=true;
		}
		if(moveScript.m_IsWalking==true && this.reloadAnim.GetCurrentAnimatorStateInfo(0).IsName("ReloadPistol") )
		{
			
			reloadAnim.SetBool("Reload",false);
		}
		


	}
}
