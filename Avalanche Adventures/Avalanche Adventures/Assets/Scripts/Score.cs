﻿using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public bool isDead = false;

	private float sHeight;
	private float sWidth;

	public int score = 0;

	public GUIStyle scoreStyle;
	public GUIStyle GOStyle;

	// Use this for initialization
	void Start () {
		sHeight = Screen.height;
		sWidth = Screen.width;
	}
	
	// Update is called once per frame
	void Update () {
		if(!isDead)
		score++;
	}

	void OnGUI () {
		GUI.Box (new Rect (sWidth / 4, 0, sWidth / 2, sHeight / 15), "");
		string scoreLabel = "Score: " + score;
		GUI.Label (new Rect (sWidth / 4, 0, sWidth / 2, sHeight / 15), scoreLabel, scoreStyle); 


		if (isDead) {
			GUI.Label (new Rect (0, sHeight / 3, sWidth, sHeight), "Game Over", GOStyle);
			if (GUI.Button (new Rect (sWidth / 2 - sWidth / 10, sHeight / 2 , sWidth / 5, sHeight / 10), "Retry")) {
				Application.LoadLevel(1);
			}
			
			if (GUI.Button (new Rect (sWidth / 2 - sWidth / 10, sHeight *2/3, sWidth / 5, sHeight / 10), "Main Menu")) {
				Application.LoadLevel(0);
			}
		}
	}

}
