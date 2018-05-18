using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExperience : MonoBehaviour {


	public int currentLevel;
	public int currentExp;
	public int[] toLevelUp;
	public int realCurrentLevel;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		if (currentExp >= toLevelUp [currentLevel]) {
				currentLevel++;
				LevelUpStats ();
			
		}
		realCurrentLevel = currentLevel + 1;
	}
	public void AddExperience(int ExperienceToAdd){
	
		currentExp += ExperienceToAdd;
	}
	public void LevelUpStats(){
	
		GameInfo.Strength += 2;
		GameInfo.Agility += 1;
		GameInfo.HitPoints += 15;
	
	
	}
}
