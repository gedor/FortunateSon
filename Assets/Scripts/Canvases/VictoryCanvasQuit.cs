using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryCanvasQuit : MonoBehaviour {

	public Canvas Vic;
	// Use this for initialization
	void Start () {
		Vic.gameObject.SetActive(false);
		}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ExitGame(){

		Application.Quit ();
	}
	public void LoadExtraCredits(){
		SceneManager.LoadScene ("Credits");
	}
}
