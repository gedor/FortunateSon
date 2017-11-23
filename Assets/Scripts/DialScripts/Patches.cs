using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patches : MonoBehaviour {


	public RPGTalk rpgPatch;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){



		if (Input.GetKeyUp (KeyCode.F)) {


				if (GameObject.Find ("Father").GetComponent<FatherGallhager> ().gotCure == false) {
					
					rpgPatch.NewTalk ("1", "7");

			
			} else if (GameObject.Find ("Father").GetComponent<FatherGallhager> ().gotCure == true) {
				
					rpgPatch.NewTalk ("9", "10");


				}
		


		}
	}

}
