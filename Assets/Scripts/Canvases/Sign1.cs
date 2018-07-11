using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sign1 : MonoBehaviour {


	public Canvas signprvo;

	// Use this for initialization
	void Start () {
		signprvo.gameObject.SetActive(false);
	}


	void OnTriggerStay2D(Collider2D other){

		if(Input.GetButtonDown("Fire1") || Input.GetKeyUp(KeyCode.F)){
			if (signprvo.isActiveAndEnabled == false) {
				
				signprvo.gameObject.SetActive(true);

			} else {
				signprvo.gameObject.SetActive(false);
			
			}
	}


	}
	void OnTriggerExit2D(Collider2D other){
	
		if (signprvo.isActiveAndEnabled == true) {
		
			signprvo.gameObject.SetActive(false);
		}
	}

}
