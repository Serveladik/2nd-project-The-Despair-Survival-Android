using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScript : MonoBehaviour {

public GameObject menu;
public GameObject settings;
	// Use this for initialization
	
	
	// Update is called once per frame
	public void BackButtonToMenu()
	{
		settings.SetActive(false);
		menu.SetActive(true);
	}
}
