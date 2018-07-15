using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour {

	public EventSystem eve;
	public GameObject selectedObject;

	private bool buttonSelected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw("Vertical") !=0 && buttonSelected == false){

			eve.SetSelectedGameObject(selectedObject);
			buttonSelected = true;
		}
	}
	public void StartNewGame(){
	
		SceneManager.LoadScene ("StatMenu");
	
	}
	public void ExitGame(){
		Application.Quit ();
	}
	public void Controls(){
	
		SceneManager.LoadScene ("Controls");
	
	}
	private void OnDisable() {
	buttonSelected = false;	
	}
}
