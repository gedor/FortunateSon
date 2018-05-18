using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour {

	public Transform playerPaladin;
	public Transform playerWarrior;
	public Transform playerRogue;
	public Transform characterSpawner;


	// Use this for initialization
	void Awake () {
		characterSpawner = GetComponent<Transform> ();

		if (GameInfo.ClassName == "Warrior") {
			Instantiate (playerWarrior, characterSpawner.position,transform.rotation);
		
		} else if(GameInfo.ClassName == "Rogue") {
			Instantiate (playerRogue, characterSpawner.position, transform.rotation);
		
		}else if(GameInfo.ClassName == "Paladin") {
			Instantiate (playerPaladin, characterSpawner.position, transform.rotation);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
