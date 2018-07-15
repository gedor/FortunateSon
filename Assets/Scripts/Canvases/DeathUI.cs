using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DeathUI : MonoBehaviour {


	private PlayerHealthManager pla;
	public Canvas deathCanvas;

	public Button exitGam;

	public EventSystem eve;
	public GameObject selectedObject;
	private bool buttonSelected;
	// Use this for initialization
	void Start () {
		pla = GameObject.FindWithTag("Player").GetComponent<PlayerHealthManager> ();
		deathCanvas.enabled = false;
		exitGam.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (pla.dying == true) {
			StartCoroutine ("plaDead");
		
		}
		if (deathCanvas.enabled == true && Input.GetAxisRaw("Vertical") !=0 && buttonSelected == false){
			eve.SetSelectedGameObject(selectedObject);
			buttonSelected = true;

			}
	}
			public void ExitGame(){

				Application.Quit ();

			}
	public IEnumerator plaDead(){
	
		yield return new WaitForSeconds (1.0f);
		deathCanvas.enabled = true;
		exitGam.interactable = true;
	}
	private void OnDisable() {
	buttonSelected = false;	
	
	}
}
