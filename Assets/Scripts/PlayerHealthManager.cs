using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealthManager : MonoBehaviour {


	public int playerMaxHealth;

	public int playerCurrentHealth;

	public int playerStrength;
	public int playerAgility;
	public int playerCharisma;
	public int playerPerception;

	public GameObject Self;
	public Animator anim;
	public bool dying;
	// Use this for initialization
	void Start() {
		playerMaxHealth = GameInfo.HitPoints;
		playerCurrentHealth = playerMaxHealth;
		dying = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (playerCurrentHealth <= 0) {
		
			StartCoroutine ("PlayerDead");
		
		
		}
		playerStrength = GameInfo.Strength;
		playerAgility = GameInfo.Agility;
		playerCharisma = GameInfo.Charisma;
		playerPerception = GameInfo.Perception;
	}


	public void HurtPlayer(int damageToGive){
	
		playerCurrentHealth -= damageToGive;

	
	}
	public void SetMaxHealth()
	{
	
		playerCurrentHealth = playerMaxHealth;
	}
	public IEnumerator PlayerDead(){

		dying = true;
		anim.SetBool ("IsDead", true);
		yield return new WaitForSeconds(1.0f);
		Self.SetActive(false);

	}


}
