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
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){



		if(Input.GetKeyUp(KeyCode.F))
		{

			if (signprvo.enabled == false) {

				signprvo.enabled = true;

			}
			else {

				signprvo.enabled = false;
	
			}

		}
	}
}
