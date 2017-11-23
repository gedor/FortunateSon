using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Slider HealthBar;
	public Text levelText;
	public Text expText;

	public PlayerHealthManager playerHealth;
	private PlayerExperience thePE;

	private static bool UIExists;

	// Use this for initialization
	void Start () {
		thePE = gameObject.GetComponent<PlayerExperience> ();
		playerHealth = GameObject.FindWithTag ("Player").GetComponent<PlayerHealthManager>();
		if (!UIExists) {
		
			UIExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		HealthBar.maxValue = playerHealth.playerMaxHealth;
		HealthBar.value = playerHealth.playerCurrentHealth;
		levelText.text = "Lvl: " + thePE.currentLevel;
		expText.text = "Exp: " + thePE.currentExp;
	}
}
