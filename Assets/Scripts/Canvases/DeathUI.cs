using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeathUI : MonoBehaviour {


	private PlayerHealthManager pla;
	public Canvas deathCanvas;
	// Use this for initialization
	void Start () {
		pla = GameObject.FindWithTag("Player").GetComponent<PlayerHealthManager> ();
		deathCanvas.gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		if (pla.dying == true) {
			StartCoroutine ("plaDead");
		
		}
		
	}
			public void ExitGame(){

				Application.Quit ();

			}
	public IEnumerator plaDead(){
	
		yield return new WaitForSeconds (1.0f);
		deathCanvas.gameObject.SetActive(true);
	}
}
