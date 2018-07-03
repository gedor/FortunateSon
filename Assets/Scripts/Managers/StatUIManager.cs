using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatUIManager : MonoBehaviour {

	public Canvas StatUI;
	public Text Strength;
	public Text Perception;
	public Text Agility;
	public Text Charisma;

	// Use this for initialization
	void Start () {
		StatUI.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		Strength.text = "Strength: " + GameInfo.Strength;
		Agility.text = "Agility: " + GameInfo.Agility;
		Perception.text = "Perception: " + GameInfo.Perception;
		Charisma.text = "Charisma: " + GameInfo.Charisma;
		if(Input.GetButtonDown("Cancel") || Input.GetKeyUp(KeyCode.I))
		{

			if (StatUI.enabled == false) {

				StatUI.enabled = true;


			}
			else {

				StatUI.enabled = false;

			}

		}
	}


}
