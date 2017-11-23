using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfo {


	public static void LoadAllInfo(){


		GameInfo.ClassName = PlayerPrefs.GetString ("PlayerClassName");
		GameInfo.Strength = PlayerPrefs.GetInt ("PlayerStrength");
		GameInfo.Perception = PlayerPrefs.GetInt ("PlayerPerception");
		GameInfo.Agility = PlayerPrefs.GetInt ("PlayerAgility");
		GameInfo.Charisma = PlayerPrefs.GetInt ("PlayerCharisma");
		GameInfo.HitPoints = PlayerPrefs.GetInt ("PlayerHitPoints");
	}
}
