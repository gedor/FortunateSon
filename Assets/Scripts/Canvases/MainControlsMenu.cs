using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainControlsMenu : MonoBehaviour {




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackToMain(){
	
		SceneManager.LoadScene ("MainMenu");
	}
	private void OnEnable() {
		
	}
}
