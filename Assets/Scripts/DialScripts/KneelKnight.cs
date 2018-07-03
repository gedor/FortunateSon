using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KneelKnight : MonoBehaviour {

	public RPGTalk rpgKnee;
	public bool talkedToKnight;

	public Canvas PressFKnight;
	private float lastPressed;
	// Use this for initialization
	void Start () {
		talkedToKnight = false;
		rpgKnee.OnEndTalk += OnEndTalk;
		PressFKnight.enabled = false;
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

		if (PressFKnight.enabled == false) {
			PressFKnight.enabled = true;

		}

	}
	void OnTriggerExit2D(Collider2D other){
		if (PressFKnight.enabled == true) {
			PressFKnight.enabled = false;

		}

	}
	void OnTriggerStay2D(Collider2D other){


		if (lastPressed != Time.deltaTime) {
			if (Input.GetButtonDown("Fire1") || Input.GetKeyUp (KeyCode.F)) {

				if (rpgKnee.isPlaying == false) {
					if (GameObject.Find ("Guard").GetComponent<CaveGuard> ().talkedToGuard == true) {
						lastPressed = Time.deltaTime;
						GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
						rpgKnee.NewTalk ("3", "5");
						talkedToKnight = true;

					} else if (GameObject.Find ("Guard").GetComponent<CaveGuard> ().talkedToGuard == false) {
						lastPressed = Time.deltaTime;
						GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
						rpgKnee.NewTalk ("1", "1");

					}



				}
			}
		}
	}
}
