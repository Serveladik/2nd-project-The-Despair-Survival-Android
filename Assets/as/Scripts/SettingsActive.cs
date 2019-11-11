using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsActive : MonoBehaviour {

public GameObject menu;
public GameObject settings;

	public void SettingsButton()
	{
		menu.SetActive(false);
		settings.SetActive(true);
	}

}
