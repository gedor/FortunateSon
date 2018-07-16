using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FatherGallhager : MonoBehaviour {


	public Canvas VictoryCanvas;
	public RPGTalk rpgFather;
	public bool gotCure = false;
	public Canvas TrueVictoryCanvas;

	public Canvas PressF;
	private float lastPressed;

	public Button vicExtraCreditsButton;
	public Button vicExitGameButton;

	public Button trueVicExtraCreditsButton;
	public Button trueVicExitGameButton;

	
	
	
	// Use this for initialization
	void Start () {
		VictoryCanvas.enabled = false;
		TrueVictoryCanvas.enabled = false;
		rpgFather.OnEndTalk += OnEndTalk;
		PressF.enabled = false;

		vicExtraCreditsButton.interactable = false;
		vicExitGameButton.interactable = false;
		
	
	}

	void OnEndTalk ()
	{
		lastPressed = 0.0f;
		GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = true;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D other){

		if (PressF.enabled == false) {
			PressF.enabled = true;

		}

	}
	void OnTriggerExit2D(Collider2D other){
		if (PressF.enabled == true) {
			PressF.enabled = false;

		}

	}

	void OnTriggerStay2D(Collider2D other){
		

			if (Input.GetButtonDown("Fire1") || Input.GetKeyUp (KeyCode.F)) {
			
			if (GameObject.Find ("KneelKnight").GetComponent<KneelKnight> ().talkedToKnight == true) {

				PressF.enabled = false;
				TrueVictoryCanvas.enabled = true;

				trueVicExtraCreditsButton.interactable = true;
				trueVicExitGameButton.interactable = true;
				trueVicExtraCreditsButton.Select();


				Time.timeScale = 0.0f;

			} else if (GameObject.Find ("KneelKnight").GetComponent<KneelKnight> ().talkedToKnight == false) {
			

				if (gotCure == true) {
					PressF.enabled = false;
					VictoryCanvas.enabled = true;

					vicExtraCreditsButton.interactable = true;
					vicExitGameButton.interactable = true;
					vicExtraCreditsButton.Select();
					Time.timeScale = 0.0f;
						

				} else if (gotCure == false) {
					if (lastPressed != Time.deltaTime) {
				
						if (GameObject.Find ("CaptainAnderson").GetComponent<CaptainAnderson> ().talkedToAnderson == true) {
							PressF.enabled = false;
							lastPressed = Time.deltaTime;
							GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
							rpgFather.NewTalk ("1", "4");

				

						} else if (GameObject.Find ("CaptainAnderson").GetComponent<CaptainAnderson> ().talkedToAnderson == false) {
							PressF.enabled = false;
							lastPressed = Time.deltaTime;
							GameObject.FindWithTag ("Player").GetComponent<PlayerMovement> ().CanMove = false;
							rpgFather.NewTalk ("6", "6");

					 


						}
					}
				}
			}
		}

	}


}

