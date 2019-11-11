using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ContinueButtonGame : MonoBehaviour {

public CameraScript mouseLook;
public ShotAllow shoot;
public FirstPersonControllerFix movement;
public GameObject menu;


	public void Continue()
	{
		//menuButton.MenuButtonScript1=false;
		movement.enabled=true;
		menu.SetActive(false);
		mouseLook.enabled = true;
		Cursor.visible = false;
		shoot.shoot = true;
	
		Time.timeScale = 1f;
		
	}
	
}
