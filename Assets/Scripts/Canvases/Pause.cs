using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public Button exitGameButton;
	public Button resumeButton;
	public Button controlsButton;
	public Canvas pauseCanvas;

	public Canvas victoryCanvas;
	public Canvas trueVictoryCanvas;
	public Canvas deathCanvas;
	public Canvas controlsCanvas;
	// Use this for initialization
	void Start () {
		pauseCanvas.gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		if (victoryCanvas.isActiveAndEnabled == false && trueVictoryCanvas.isActiveAndEnabled == false && deathCanvas.isActiveAndEnabled == false) 
		{
			if (Input.GetButtonDown("Menu") || Input.GetKeyUp (KeyCode.Escape)) {

				if (pauseCanvas.isActiveAndEnabled == false) {
			
					pauseCanvas.gameObject.SetActive(true);
					Time.timeScale = 0.0f;
				} else {
			
					pauseCanvas.gameObject.SetActive(false);
					Time.timeScale = 1.0f;
				}

			}

		}
	}
			public void ResumeGame(){
	
		pauseCanvas.gameObject.SetActive(false);
		Time.timeScale = 1.0f;
			}
			public void ExitGame(){
	
		Application.Quit ();
			}
	public void ControlsButton(){

		if (controlsCanvas.isActiveAndEnabled == false) {

			controlsCanvas.gameObject.SetActive(true);
		}
	}
}
