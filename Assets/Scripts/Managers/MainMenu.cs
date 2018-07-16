using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	
	//public Button selectedObject;



	// Use this for initialization
	void Start () {
	//	selectedObject.Select();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void StartNewGame(){
	
		SceneManager.LoadScene ("StatMenu");
	
	}
	public void ExitGame(){
		Application.Quit ();
	}
	public void Controls(){
	
		SceneManager.LoadScene ("Controls");
	
	}
	
	
}
