using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreatePlayer : MonoBehaviour {

	private BasePlayerClass newPlayer;



	public Text strengthText;
	public Text perceptionText;
	public Text agilityText;
	public Text charismaText;
	public Text hitpointsText;


	private int PointsToSpend = 0;
	public Text pointsText;





	void Start(){
		newPlayer = new BasePlayerClass();
		UpdateUI ();
	}

	public void CreateNewPlayer(){
	
		GameInfo.ClassName = newPlayer.ClassName;
		GameInfo.Strength = newPlayer.Strength;
		GameInfo.Agility = newPlayer.Agility;
		GameInfo.Charisma = newPlayer.Charisma;
		GameInfo.Perception = newPlayer.Perception;
		GameInfo.HitPoints = newPlayer.HitPoints;

		SaveInfo.SaveAllInfo ();
		SceneManager.LoadScene ("MainGame");
	}


	public void SetPaladinClass(){


		PointsToSpend = 5;
		newPlayer.PlayerClass = new BasePaladinClass();
		newPlayer.ClassName = newPlayer.PlayerClass.ClassName;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Perception = newPlayer.PlayerClass.Perception;
		newPlayer.Agility = newPlayer.PlayerClass.Agility;
		newPlayer.Charisma = newPlayer.PlayerClass.Charisma;
		newPlayer.HitPoints = newPlayer.PlayerClass.HitPoints;

		UpdateUI ();
	}
	public void SetWarriorClass(){
	

		PointsToSpend = 5;
		newPlayer.PlayerClass = new BaseWarriorClass();
		newPlayer.ClassName = newPlayer.PlayerClass.ClassName;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Perception = newPlayer.PlayerClass.Perception;
		newPlayer.Agility = newPlayer.PlayerClass.Agility;
		newPlayer.Charisma = newPlayer.PlayerClass.Charisma;
		newPlayer.HitPoints = newPlayer.PlayerClass.HitPoints;

		UpdateUI ();
	}
	public void SetRogueClass(){


		PointsToSpend = 5;
		newPlayer.PlayerClass = new BaseRogueClass();
		newPlayer.ClassName = newPlayer.PlayerClass.ClassName;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Perception = newPlayer.PlayerClass.Perception;
		newPlayer.Agility = newPlayer.PlayerClass.Agility;
		newPlayer.Charisma = newPlayer.PlayerClass.Charisma;
		newPlayer.HitPoints = newPlayer.PlayerClass.HitPoints;

		UpdateUI ();
	}
	void UpdateUI(){
		
		strengthText.text = newPlayer.Strength.ToString ();
		perceptionText.text = newPlayer.Perception.ToString ();
		agilityText.text = newPlayer.Agility.ToString ();
		charismaText.text = newPlayer.Charisma.ToString ();
		hitpointsText.text = newPlayer.HitPoints.ToString ();
		pointsText.text = PointsToSpend.ToString ();
	}

	public void SetStrength(int amount){
	
		if (newPlayer.PlayerClass != null) {
		
			if (amount > 0 && PointsToSpend > 0) {
			
				newPlayer.Strength += amount;
				PointsToSpend -= 1;
				UpdateUI ();
			
			} else if (amount <= 0 && newPlayer.Strength > newPlayer.PlayerClass.Strength) {
			
				newPlayer.Strength += amount;
				PointsToSpend += 1;
				UpdateUI ();
			}
		
		}
	
	
	}
	public void SetPerception(int amount){

		if (newPlayer.PlayerClass != null) {

			if (amount > 0 && PointsToSpend > 0) {

				newPlayer.Perception += amount;
				PointsToSpend -= 1;
				UpdateUI();

			}else if (amount <= 0 && newPlayer.Perception > newPlayer.PlayerClass.Perception) {

				newPlayer.Perception += amount;
				PointsToSpend += 1;
				UpdateUI ();
			}

		}


	}
	public void SetAgility(int amount){

		if (newPlayer.PlayerClass != null) {

			if (amount > 0 && PointsToSpend > 0) {

				newPlayer.Agility += amount;
				PointsToSpend -= 1;
				UpdateUI();

			}else if (amount <= 0 && newPlayer.Agility > newPlayer.PlayerClass.Agility) {

				newPlayer.Agility += amount;
				PointsToSpend += 1;
				UpdateUI ();
			}

		}


	}
	public void SetCharisma(int amount){

		if (newPlayer.PlayerClass != null) {

			if (amount > 0 && PointsToSpend > 0) {

				newPlayer.Charisma += amount;
				PointsToSpend -= 1;
				UpdateUI();

			}else if (amount <= 0 && newPlayer.Charisma > newPlayer.PlayerClass.Charisma) {

				newPlayer.Charisma += amount;
				PointsToSpend += 1;
				UpdateUI ();
			}

		}


	}
	public void SetHitPoints(int amount){

		if (newPlayer.PlayerClass != null) {

			if (amount > 0 && PointsToSpend > 0) {

				newPlayer.HitPoints += amount;
				PointsToSpend -= 1;
				UpdateUI();

			}else if (amount <= 0 && newPlayer.HitPoints > newPlayer.PlayerClass.HitPoints) {

				newPlayer.HitPoints += amount;
				PointsToSpend += 1;
				UpdateUI ();
			}

		}


	}

}
