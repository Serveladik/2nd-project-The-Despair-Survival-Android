using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class RunToIdle : MonoBehaviour {

public FireButtonScript fireButton;
	public Animator animator;
	public bool runInAnim=false;
	public FirstPersonControllerFix allowRuning;
	public RunButton runBtn;
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(runInAnim==true && fireButton.fireButton==true)
		{
			animator.SetBool("ShotWhileRun",true);
			animator.SetBool("RunWithPistol",false);
			runInAnim=false;
			allowRuning.m_IsWalking=true;
			Debug.Log("WALK!");
		
		}
	}

	void Run()
	{
		runBtn.RunPressed=true;
		runInAnim=true;
		allowRuning.m_IsWalking=false; 
	}
	void NoRun()
	{
		runBtn.RunPressed=false;
		allowRuning.m_IsWalking=true; 
		runInAnim=false;
	}
}


