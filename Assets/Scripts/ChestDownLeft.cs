using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestDownLeft : MonoBehaviour {

	public bool alreadyChest;
	public Canvas ChestUI;
	// Use this for initialization
	void Start () {
		ChestUI.enabled = false;
		alreadyChest = false;
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
	public IEnumerator ChestSnowyDownLeft(){
		ChestUI.enabled = true;
		GameInfo.Strength += 2;
		yield return new WaitForSeconds (3.0f);
		ChestUI.enabled = false;
	}
}
