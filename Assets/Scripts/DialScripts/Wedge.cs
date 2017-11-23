using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wedge : MonoBehaviour {

	public bool AbleToKillBoss = false;
	public RPGTalk rpgWedg;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){


	
			if (Input.GetKeyUp (KeyCode.F)) {
				if (GameInfo.Charisma >= 14) {
					if (GameObject.Find ("Father").GetComponent<FatherGallhager> ().gotCure == false) {
						;
						AbleToKillBoss = true;
						rpgWedg.NewTalk ("1", "11");
						

			
					} else if (GameObject.Find ("Father").GetComponent<FatherGallhager> ().gotCure == true) {
						
						rpgWedg.NewTalk ("15", "15");
						

					}


		
			} else if (GameInfo.Charisma < 14) {
					
					rpgWedg.NewTalk ("13", "13");


				}
			}
		}

	}


