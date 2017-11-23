using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Intro : MonoBehaviour {

	public Canvas paladin;
	public Canvas warrior;
	public Canvas rogue;
	// Use this for initialization
	void Awake(){

		paladin.enabled = false;
		warrior.enabled = false;
		rogue.enabled = false;
	}
	void Start () {
		if (GameInfo.ClassName == "Paladin") {

			paladin.enabled = true;

		} else if (GameInfo.ClassName == "Warrior") {

			warrior.enabled = true;
		} else if (GameInfo.ClassName == "Rogue") {

			rogue.enabled = true;

		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.F))
		{

			if (paladin.enabled == true || warrior.enabled == true || rogue.enabled == true) {

				paladin.enabled = false;
				warrior.enabled = false;
				rogue.enabled = false;

			}


		}
	}


}
