using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerClass {


	private BaseClass playerClass;




	private string classname;
	private int strength;
	private int perception;
	private int agility;
	private int charisma;
	private int hitpoints;


	public BaseClass PlayerClass{

		get { return playerClass; }
		set { playerClass = value;}
	}




	public string ClassName{

		get { return classname; }
		set { classname = value;}
	}
	public int Strength{

		get { return strength; }
		set { strength = value;}
	}

	public int Perception{

		get { return perception; }
		set { perception = value; }
	}
	public int Agility{

		get { return agility; }
		set { agility = value;}

	}

	public int Charisma{

		get { return charisma; }
		set { charisma = value;}

	}
	public int HitPoints{

		get { return hitpoints; }
		set { hitpoints = value;}

	}
}
