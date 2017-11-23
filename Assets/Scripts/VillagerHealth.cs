using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerHealth : MonoBehaviour {



	public int villMaxHealth;
	public int villCurrentHealth;

	Animator animaVill;
	// Use this for initialization
	void Start () {
		animaVill = GetComponent<Animator> ();
		villCurrentHealth = villMaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (villCurrentHealth <= 0) {


			StartCoroutine ("VillDead");

		} 
	}
	public void HurtEnemy(int damageToGive){

		villCurrentHealth -= damageToGive;


	}
	public void SetMaxHealth()
	{

		villCurrentHealth = villMaxHealth;
	}
	public IEnumerator VillDead(){


		animaVill.SetBool ("IsDead", true);
		yield return new WaitForSeconds(1.3f);
		Destroy (gameObject);
	}

}
