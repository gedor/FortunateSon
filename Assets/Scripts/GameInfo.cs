using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (this.gameObject);
	
	
	}

	public static BaseClass PlayerClass { get; set;}

	public static string ClassName { get; set;}
	public static int Strength { get; set;}
	public static int Perception { get; set;}
	public static int Agility { get; set;}
	public static int Charisma { get; set;}
	public static int HitPoints { get; set;}
}
