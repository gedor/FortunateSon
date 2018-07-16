using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsCanvas : MonoBehaviour {



	public Canvas controlsCanvas;
	public Button back;
	
	
	private bool buttonSelected;
	public Canvas pauseCan;
	public Button selPaus;
	// Use this for initialization
	void Awake () {
		controlsCanvas.enabled = false;
		back.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackToMenu(){
	
		if (controlsCanvas.isActiveAndEnabled == true) {
			controlsCanvas.enabled = false;
			pauseCan.enabled = true;
			
			selPaus.Select();
			back.interactable = false;
			Time.timeScale = 0.0f;
		}
	}


}
