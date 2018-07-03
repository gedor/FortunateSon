using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sign1 : MonoBehaviour {


	public Canvas signprvo;

	// Use this for initialization
	void Start () {
		signprvo.enabled = false;
	}


	void OnTriggerStay2D(Collider2D other){

		if(Input.GetButtonDown("Fire1") || Input.GetKeyUp(KeyCode.F)){
			if (signprvo.enabled == false) {
				
				signprvo.enabled = true;

			} else {
				signprvo.enabled = false;
			
			}
	}


	}
	void OnTriggerExit2D(Collider2D other){
	
		if (signprvo.enabled == true) {
		
			signprvo.enabled = false;
		}
	}

}
