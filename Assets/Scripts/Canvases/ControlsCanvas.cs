using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsCanvas : MonoBehaviour {



	public Canvas controlsCanvas;

	// Use this for initialization
	void Awake () {
		controlsCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackToMenu(){
	
		if (controlsCanvas.enabled == true) {
		
			controlsCanvas.enabled = false;
		}
	}
}
