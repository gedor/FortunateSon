using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFader : MonoBehaviour {

	Animator anim;
	bool IsFading = false;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	public IEnumerator FadeToClear(){
	
		IsFading = true;
		anim.SetTrigger("FadeIn");
		while (IsFading)
			yield return null;
	}

	public IEnumerator FadeToBlack(){
		anim.SetTrigger("FadeOut");
		while (IsFading)
			yield return null;
	}
	
	void AnimationComplete(){
		IsFading = false;
	}
}
