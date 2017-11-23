using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveGuard : MonoBehaviour {




	public RPGTalk rpgCaveG;
	private float lastPressed;
	public bool talkedToGuard;
	// Use this for initialization
	void Start () {
		talkedToGuard = false;
		rpgCaveG.OnMadeChoice += OnMadeChoice;
	}

	void OnMadeChoice (int questionID, int choiceNumber)
	{
		if (questionID == 2) {
			if (choiceNumber == 0) {
				rpgCaveG.NewTalk ("5", "5");
				talkedToGuard = true;
				lastPressed = 0.0f;


			} else if(choiceNumber == 1){

				rpgCaveG.NewTalk ("7", "7");
				lastPressed = 0.0f;

			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){



		if (lastPressed != Time.deltaTime) {
			if (Input.GetKeyUp (KeyCode.F)) {

				lastPressed = Time.deltaTime;

				rpgCaveG.NewTalk ("1", "3");


			}
		}
	}
}
