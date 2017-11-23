using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KneelKnight : MonoBehaviour {

	public RPGTalk rpgKnee;
	public bool talkedToKnight;
	// Use this for initialization
	void Start () {
		talkedToKnight = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){



		if (Input.GetKeyUp (KeyCode.F)) {


			if (GameObject.Find("Guard").GetComponent<CaveGuard>().talkedToGuard == true) {

				rpgKnee.NewTalk ("3", "5");
				talkedToKnight = true;

			} else if (GameObject.Find("Guard").GetComponent<CaveGuard>().talkedToGuard == false) {

				rpgKnee.NewTalk ("1", "1");

			}



		}
	}
}
