using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : MonoBehaviour {


	public RPGTalk rpgVill;
	// Use this for initialization
	void Start () {
		rpgVill.OnMadeChoice += OnMadeChoice;
	}

	void OnMadeChoice (int questionID, int choiceNumber)
	{
		if (questionID == 1) {
			if (choiceNumber == 0) {
				rpgVill.NewTalk ("5", "7");


			} else if(choiceNumber == 1){
				

			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){



			
			if (Input.GetKeyUp (KeyCode.F)) {
				

				rpgVill.NewTalk ("1", "3");



		}
	}

}
