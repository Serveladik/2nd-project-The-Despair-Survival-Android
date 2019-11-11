using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewGameScript : MonoBehaviour {

	// Use this for initialization
	public void NewGame()
	{
		SceneManager.LoadScene("GameScene");
	}
}
