using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FatherGallhager : MonoBehaviour {


	public Canvas VictoryCanvas;
	public RPGTalk rpgFather;
	public bool gotCure = false;
	public Canvas TrueVictoryCanvas;
	// Use this for initialization
	void Start () {
		VictoryCanvas.enabled = false;
		TrueVictoryCanvas.enabled = false;
		//capt = GetComponent<CaptainAnderson> ();
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay2D(Collider2D other){


			if (Input.GetKeyUp (KeyCode.F)) {
			
			if (GameObject.Find ("KneelKnight").GetComponent<KneelKnight> ().talkedToKnight == true) {


				TrueVictoryCanvas.enabled = true;
				Time.timeScale = 0.0f;

			} else if (GameObject.Find ("KneelKnight").GetComponent<KneelKnight> ().talkedToKnight == false) {
			

				if (gotCure == true) {
					
					VictoryCanvas.enabled = true;
					Time.timeScale = 0.0f;
						

				} else if (gotCure == false) {
				
					if (GameObject.Find ("CaptainAnderson").GetComponent<CaptainAnderson> ().talkedToAnderson == true) {
					
						rpgFather.NewTalk ("1", "4");

				

					} else if (GameObject.Find ("CaptainAnderson").GetComponent<CaptainAnderson> ().talkedToAnderson == false) {
					
						rpgFather.NewTalk ("6", "6");

					 


					}
				}
			}
		}

	}


}

