using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveGuard : MonoBehaviour {




	public RPGTalk rpgCaveG;
	private float lastPressed;
	public bool talkedToGuard;
	public Canvas PressFGuard;
	// Use this for initialization
	void Start () {
		talkedToGuard = false;
		rpgCaveG.OnMadeChoice += OnMadeChoice;
		PressFGuard.enabled = false;
		rpgCaveG.OnEndTalk += OnEndTalk;
	
	}

	void OnEndTalk ()
	{
		GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = true;
		lastPressed = 0.0f;
	}



	void OnMadeChoice (int questionID, int choiceNumber)
	{
		if (questionID == 2) {
			if (choiceNumber == 0) {
				if (rpgCaveG.isPlaying == false) {
					talkedToGuard = true;
					GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
					rpgCaveG.NewTalk ("5", "5");
					lastPressed = 0.0f;


				}else if(rpgCaveG.isPlaying == false){}
			} else if (choiceNumber == 1) {
				if (rpgCaveG.isPlaying == false) {
					GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
					rpgCaveG.NewTalk ("7", "7");
					lastPressed = 0.0f;

				}
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}



	void OnTriggerStay2D(Collider2D other){



		if (lastPressed != Time.deltaTime) {
			if (Input.GetKeyUp (KeyCode.F)) {
				
				if (GameObject.Find ("Patches").GetComponent<Patches> ().talkedToPatches == true) {
					if (rpgCaveG.isPlaying == false) {

						lastPressed = Time.deltaTime;
						GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
						rpgCaveG.NewTalk ("1", "3");


					}
				} else if (GameObject.Find ("Patches").GetComponent<Patches> ().talkedToPatches == false) {
					if (rpgCaveG.isPlaying == false) {	
						lastPressed = Time.deltaTime;
						GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
						rpgCaveG.NewTalk ("9", "9");



					}
				}
				}
			}
		}

	void OnTriggerEnter2D(Collider2D other){

		if (PressFGuard.enabled == false) {
			PressFGuard.enabled = true;

		}

	}
	void OnTriggerExit2D(Collider2D other){
		if (PressFGuard.enabled == true) {
			PressFGuard.enabled = false;

		}

	}


}
