using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainAnderson : MonoBehaviour {

	public RPGTalk rpgCaptainAnderson;
	public bool talkedToAnderson;

	public Canvas PressFAnd;
	private float lastPressed;
	// Use this for initialization
	void Start () {
		PressFAnd.enabled = false;
		talkedToAnderson = false;
		rpgCaptainAnderson.OnMadeChoice += OnMadeChoice;
		rpgCaptainAnderson.OnEndTalk += OnEndTalk;

	}

	void OnEndTalk ()
	{
		GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = true;
	}



	void OnMadeChoice (int questionID, int choiceID)
	{
		if (questionID == 0) {
			if (choiceID == 0) {
				if (rpgCaptainAnderson.isPlaying == false) {
					rpgCaptainAnderson.NewTalk ("5", "9");
					
					talkedToAnderson = true;
					lastPressed = 0.0f;
					
					GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;

				}


			} else if (choiceID == 1) {
				if (rpgCaptainAnderson.isPlaying == false) {
					talkedToAnderson = true;
					
					rpgCaptainAnderson.NewTalk ("11", "15");

					lastPressed = 0.0f;
					GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;


				}
			}
		}

	}
	void Update(){


	}
	void OnTriggerEnter2D(Collider2D other){

		if (PressFAnd.enabled == false) {
			PressFAnd.enabled = true;

		}

	}
	void OnTriggerExit2D(Collider2D other){
		if (PressFAnd.enabled == true) {
			PressFAnd.enabled = false;

		}

	}
	void OnTriggerStay2D(Collider2D other){
	


		if (lastPressed != Time.deltaTime) {
			if (Input.GetButtonDown("Fire1") || Input.GetKeyUp (KeyCode.F)) {
				if (rpgCaptainAnderson.isPlaying == false) {
			
					lastPressed = Time.deltaTime;
					GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
					rpgCaptainAnderson.NewTalk ("1", "3");
					
					talkedToAnderson = true;

				}
			}
		}
	}
	
}
