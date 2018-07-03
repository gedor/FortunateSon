using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wedge : MonoBehaviour {

	public bool AbleToKillBoss = false;
	public RPGTalk rpgWedg;

	public Canvas PressFWedg;
	private float lastPressed;
	// Use this for initialization
	void Start () {
		PressFWedg.enabled = false;
		rpgWedg.OnEndTalk += OnEndTalk;
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

		if (PressFWedg.enabled == false) {
			PressFWedg.enabled = true;

		}

	}
	void OnTriggerExit2D(Collider2D other){
		if (PressFWedg.enabled == true) {
			PressFWedg.enabled = false;

		}

	}
	void OnTriggerStay2D(Collider2D other){


		if (lastPressed != Time.deltaTime) {
			if (Input.GetButtonDown("Fire1")||Input.GetKeyUp (KeyCode.F)) {
				if (GameInfo.Charisma >= 14) {
					if (GameObject.Find ("Father").GetComponent<FatherGallhager> ().gotCure == false) {
						if (rpgWedg.isPlaying == false) {
							AbleToKillBoss = true;
							lastPressed = Time.deltaTime;
							GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
							rpgWedg.NewTalk ("1", "11");
						}

			
					} else if (GameObject.Find ("Father").GetComponent<FatherGallhager> ().gotCure == true) {
						if (rpgWedg.isPlaying == false) {
							lastPressed = Time.deltaTime;
							GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
							rpgWedg.NewTalk ("15", "15");
						
						}
					}


		
				} else if (GameInfo.Charisma < 14) {
					if (rpgWedg.isPlaying == false) {
						lastPressed = Time.deltaTime;
						GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
						rpgWedg.NewTalk ("13", "13");


					}
				}
			}
		}
	}
	}


