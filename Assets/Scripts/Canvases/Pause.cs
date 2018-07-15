using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Pause : MonoBehaviour {

	public Button exitGameButton;
	public Button resumeButton;
	public Button controlsButton;

	public Button controlBack;

	public Canvas pauseCanvas;
	public Canvas victoryCanvas;
	public Canvas trueVictoryCanvas;
	public Canvas deathCanvas;
	public Canvas controlsCanvas;

	public EventSystem eve;
	public GameObject selectedObject;
	private bool buttonSelected;
	
	// Use this for initialization
	void Start () {
		pauseCanvas.enabled = false;

		exitGameButton.interactable = false;
		resumeButton.interactable = false;
		controlsButton.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
			


		if (victoryCanvas.isActiveAndEnabled == false && trueVictoryCanvas.isActiveAndEnabled == false && deathCanvas.isActiveAndEnabled == false) 
		{
			if (Input.GetButtonDown("Menu") || Input.GetKeyUp (KeyCode.Escape)) {

				if (pauseCanvas.isActiveAndEnabled == false) {
			
					pauseCanvas.enabled = true;

					exitGameButton.interactable = true;
					resumeButton.interactable = true;
					controlsButton.interactable = true;
					
					Time.timeScale = 0.0f;
				} else {
			
					pauseCanvas.enabled = false;
					Time.timeScale = 1.0f;

					exitGameButton.interactable = false;
					resumeButton.interactable = false;
					controlsButton.interactable = false;
				}

			}

		}
			if(pauseCanvas.enabled == true && Input.GetAxisRaw("Vertical") !=0 && buttonSelected == false){

			eve.SetSelectedGameObject(selectedObject);
			buttonSelected = true;
			}
	}
			public void ResumeGame(){
	
		pauseCanvas.enabled = false;

		exitGameButton.interactable = false;
		resumeButton.interactable = false;
		controlsButton.interactable = false;
		Time.timeScale = 1.0f;
			}
			public void ExitGame(){
	
		Application.Quit ();
			}
	public void ControlsButton(){

		if (controlsCanvas.isActiveAndEnabled == false) {

			controlsCanvas.enabled = true;
			controlBack.interactable = true;
			Time.timeScale = 0.0f;
		}
	}
	
	private void OnDisable() {
	buttonSelected = false;	
	
	}

	
}
