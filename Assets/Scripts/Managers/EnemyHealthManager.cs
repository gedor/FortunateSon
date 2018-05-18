using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {



	public int enemyMaxHealth;

	public int enemyCurrentHealth;

	private PlayerExperience thePlayerExperience;
	public int expToGive;

	Animator anima;
	// Use this for initialization
	void Start () {
		anima = GetComponent<Animator> ();
		enemyCurrentHealth = enemyMaxHealth;
		thePlayerExperience = GameObject.Find("UICanvas").GetComponent<PlayerExperience> ();
	}

	// Update is called once per frame
	void Update () {
		if (enemyCurrentHealth <= 0) {
			

			StartCoroutine ("Dead");

		} 
	}


	public void HurtEnemy(int damageToGive){

		enemyCurrentHealth -= damageToGive;


	}
	public void SetMaxHealth()
	{

		enemyCurrentHealth = enemyMaxHealth;
	}

	public IEnumerator Dead(){


		anima.SetBool ("IsDead", true);
		yield return new WaitForSeconds(1.0f);
		thePlayerExperience.AddExperience (expToGive);
		Destroy (gameObject);
	}
}
