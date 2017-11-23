using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform target;
	Camera MyCam;
	public float CameraSpeed = 0.1f;
	// Use this for initialization
	void Start () {
		MyCam = GetComponent<Camera> ();
		target = GameObject.FindWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		MyCam.orthographicSize = (Screen.height / 150.0f) / 2.0f;

		if (target) {
			transform.position = Vector3.Lerp (transform.position, target.position, CameraSpeed) + new Vector3(0,0,-10);
				
		}
	}
}
