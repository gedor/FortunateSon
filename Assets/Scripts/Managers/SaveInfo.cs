using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo {

	public static void SaveAllInfo(){
	
		PlayerPrefs.SetString ("PlayerClassName", GameInfo.ClassName);
		PlayerPrefs.SetInt ("PlayerStrength", GameInfo.Strength);
		PlayerPrefs.SetInt ("PlayerPerception", GameInfo.Perception);
		PlayerPrefs.SetInt ("PlayerAgility", GameInfo.Agility);
		PlayerPrefs.SetInt ("PlayerCharisma", GameInfo.Charisma);
		PlayerPrefs.SetInt ("PlayerHitPoints", GameInfo.HitPoints);

	}
}
