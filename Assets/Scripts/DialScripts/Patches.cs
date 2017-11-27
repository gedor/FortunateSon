using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patches : MonoBehaviour {


	public RPGTalk rpgPatch;
	public bool talkedToPatches;

	public Canvas PressFPatch;
	private float lastPressed;
	// Use this for initialization
	void Start () {
		PressFPatch.enabled = false;
		talkedToPatches = false;
		rpgPatch.OnEndTalk += OnEndTalk;
	}

	void OnEndTalk ()
	{
		GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = true;
		lastPressed = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (PressFPatch.enabled == false) {
			PressFPatch.enabled = true;

		}

	}
	void OnTriggerExit2D(Collider2D other){
		if (PressFPatch.enabled == true) {
			PressFPatch.enabled = false;

		}

	}
	void OnTriggerStay2D(Collider2D other){


		if (lastPressed != Time.deltaTime) {
			if (Input.GetKeyUp (KeyCode.F)) {

				if (rpgPatch.isPlaying == false) {
					if (GameObject.Find ("Father").GetComponent<FatherGallhager> ().gotCure == false) {
						lastPressed = Time.deltaTime;
						talkedToPatches = true;
						GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
						rpgPatch.NewTalk ("1", "7");

			
					} else if (GameObject.Find ("Father").GetComponent<FatherGallhager> ().gotCure == true) {
						lastPressed = Time.deltaTime;
						GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
						rpgPatch.NewTalk ("9", "10");


					}
		


				}
			}
		}
	}

}
