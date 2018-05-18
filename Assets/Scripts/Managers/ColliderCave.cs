using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Patches").GetComponent<Patches> ().talkedToPatches == true) {
		
			gameObject.SetActive (false);
		
		}
	}
}
