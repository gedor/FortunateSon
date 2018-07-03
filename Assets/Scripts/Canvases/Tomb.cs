using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tomb : MonoBehaviour {



	public bool alreadyHeal;
	public Canvas tombCan;
	public Canvas tombfailCanvas;
	// Use this for initialization
	void Start () {
		tombCan.enabled = false;
		alreadyHeal = false;
		tombfailCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){

		if (alreadyHeal != true) {
			if (Input.GetButtonDown("Fire1") || Input.GetKeyUp (KeyCode.F)) {
		
				if (GameInfo.Perception >= 13) {
					alreadyHeal = true;
					StartCoroutine ("TombCanv");
				} else if (GameInfo.Perception < 13) {
					StartCoroutine ("TombFail");
				
				
				}
			}
		}
	}
	public IEnumerator TombCanv(){
		tombCan.enabled = true;
		GameObject.FindWithTag ("Player").GetComponent<PlayerHealthManager> ().playerCurrentHealth += 50;
		yield return new WaitForSeconds (2.0f);
		tombCan.enabled = false;
	}
	public IEnumerator TombFail(){
		tombfailCanvas.enabled = true;
		yield return new WaitForSeconds (2.0f);
		tombfailCanvas.enabled = false;
	}
}
