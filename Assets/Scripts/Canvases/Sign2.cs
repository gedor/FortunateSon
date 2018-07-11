using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sign2 : MonoBehaviour {


	public Canvas sign2;
	// Use this for initialization
	void Start () {
		sign2.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){



		if(Input.GetButtonDown("Fire1") || Input.GetKeyUp(KeyCode.F))
		{

			if (sign2.isActiveAndEnabled == false) {

				sign2.gameObject.SetActive(true);

			}
			else {

				sign2.gameObject.SetActive(false);
	
			}

		}
	}
	void OnTriggerExit2D(Collider2D other){

		if (sign2.isActiveAndEnabled == true) {

			sign2.gameObject.SetActive(false);
		}
	}
}
