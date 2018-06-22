using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour {


	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotspot = Vector2.zero;
	public Texture2D cursorTexture;
	// Use this for initialization
	void Awake () {
		GameObject.DontDestroyOnLoad(this);
		Cursor.SetCursor(cursorTexture,hotspot,cursorMode);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
