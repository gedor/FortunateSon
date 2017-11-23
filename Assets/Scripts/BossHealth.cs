using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour {

	[SerializeField]
	public int bossMaxHealth;
	[SerializeField]
	public int bossCurrentHealth;

	private PlayerExperience thePlayerExperience;
	public int expToGive;

	Animator animas;
	public bool BossDead = false;

	public GameObject fath;
	// Use this for initialization
	void Start () {
		fath = GameObject.Find ("Father");
		animas = GetComponent<Animator> ();
		bossCurrentHealth = bossMaxHealth;
		thePlayerExperience = GameObject.Find("UICanvas").GetComponent<PlayerExperience> ();
	}

	// Update is called once per frame
	void Update () {
		if (bossCurrentHealth <= 0) {
			BossDead = true;

			StartCoroutine ("ToDie");

		} 

	}


	public void HurtEnemy(int damageToGive){

		bossCurrentHealth -= damageToGive;


	}
	public void SetMaxHealth()
	{

		bossCurrentHealth = bossMaxHealth;
	}

	public IEnumerator ToDie(){
		

		animas.SetBool ("IsDead", true);
		yield return new WaitForSeconds(1.0f);
		thePlayerExperience.AddExperience (expToGive);
		gameObject.SetActive (false);
	}
			void OnTriggerStay2D(Collider2D other){
	

		if(Input.GetKeyUp(KeyCode.E)){
		if (GameObject.Find ("Wedge").GetComponent<Wedge> ().AbleToKillBoss == true) {
				BossDead = true;

				StartCoroutine ("ToDie");
			}
		}
			
	}
	void OnDisable(){
		if (fath != null) {
			fath.GetComponent<FatherGallhager> ().gotCure = true;	
	
		}
		}
}
