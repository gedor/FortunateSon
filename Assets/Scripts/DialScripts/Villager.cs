using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : MonoBehaviour {


	public RPGTalk rpgVill;
	public Canvas PressFVill;

	private float lastPressed;
	// Use this for initialization
	void Start () {
		rpgVill.OnMadeChoice += OnMadeChoice;
		rpgVill.OnEndTalk += OnEndTalk;
		PressFVill.enabled = false;
	}

	void OnEndTalk ()
	{
		GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = true;
	}

	void OnMadeChoice (int questionID, int choiceNumber)
	{
		if (questionID == 1) {
			if (choiceNumber == 0) {
				if (rpgVill.isPlaying == false) {
				
					GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
					rpgVill.NewTalk ("5", "7");
					lastPressed = 0.0f;
				}

			} else if(choiceNumber == 1){
				if (rpgVill.isPlaying == false) {
					lastPressed = 0.0f;
					rpgVill.EndTalk ();
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){

		if (PressFVill.enabled == false) {
			PressFVill.enabled = true;

		}

	}
	void OnTriggerExit2D(Collider2D other){
		if (PressFVill.enabled == true) {
			PressFVill.enabled = false;

		}

	}
	void OnTriggerStay2D(Collider2D other){


		if (lastPressed != Time.deltaTime) {
			if (rpgVill.isPlaying == false) {
				if (Input.GetKeyUp (KeyCode.F)) {
					GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
					lastPressed = Time.deltaTime;

					rpgVill.NewTalk ("1", "3");

					


				}
			}
		}
	}

}
