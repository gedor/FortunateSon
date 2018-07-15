using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ControlsCanvas : MonoBehaviour {



	public Canvas controlsCanvas;
	public Button back;
	public EventSystem eve;
	public GameObject selectedObject;
	private bool buttonSelected;
	public Canvas pauseCan;
	// Use this for initialization
	void Awake () {
		controlsCanvas.enabled = false;
		back.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(controlsCanvas.enabled == true &&  Input.GetAxisRaw("Vertical") !=0 && buttonSelected == false){

			eve.SetSelectedGameObject(selectedObject);
			buttonSelected = true;
			}
	}
	public void BackToMenu(){
	
		if (controlsCanvas.isActiveAndEnabled == true) {
			pauseCan.enabled = true;
			controlsCanvas.enabled = false;
			back.interactable = false;
			Time.timeScale = 0.0f;
		}
	}

	private void OnDisable() {
	buttonSelected = false;	
	}
}
