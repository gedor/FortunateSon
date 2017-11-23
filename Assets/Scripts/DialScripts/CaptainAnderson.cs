using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainAnderson : MonoBehaviour {

	public RPGTalk rpgCaptainAnderson;
	public bool talkedToAnderson;

	private float lastPressed;
	// Use this for initialization
	void Start () {
		talkedToAnderson = false;
		rpgCaptainAnderson.OnMadeChoice += OnMadeChoice;
	}

	void OnMadeChoice (int questionID, int choiceID)
	{
		if (questionID == 0) {
			if (choiceID == 0) {
				rpgCaptainAnderson.NewTalk ("5", "9");
				lastPressed = 0.0f;


			} else if(choiceID == 1){
				
				rpgCaptainAnderson.NewTalk ("11", "15");
				lastPressed = 0.0f;

			}
		}

	}

	




	void Update(){


	}

	void OnTriggerStay2D(Collider2D other){
	


		if (lastPressed != Time.deltaTime) {
			if (Input.GetKeyUp (KeyCode.F)) {
			
				lastPressed = Time.deltaTime;

				rpgCaptainAnderson.NewTalk ("1", "3");
				talkedToAnderson = true;

			}
		}
	}


}
