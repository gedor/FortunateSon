using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestDownLeft : MonoBehaviour {

	public bool alreadyChest;
	public Canvas ChestUI;
	public Canvas PressFChest;
	// Use this for initialization
	void Start () {
		ChestUI.enabled = false;
		alreadyChest = false;
		PressFChest.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){
	
		if (alreadyChest != true) {
			if (ChestUI.enabled == false) {


				if (Input.GetKeyUp (KeyCode.F)) {
					alreadyChest = true;
					StartCoroutine ("ChestSnowyDownLeft");
				} 

			}
		}
	}
	void OnTriggerEnter2D(Collider2D other){

		if (PressFChest.enabled == false) {
			if (alreadyChest != true) {
				PressFChest.enabled = true;

			} else if (alreadyChest == true) {
				PressFChest.enabled = false;
			
			
			}
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (PressFChest.enabled == true) {
			PressFChest.enabled = false;

		}

	}
	public IEnumerator ChestSnowyDownLeft(){
		ChestUI.enabled = true;
		GameInfo.Strength += 2;
		yield return new WaitForSeconds (3.0f);
		ChestUI.enabled = false;
	}
}
