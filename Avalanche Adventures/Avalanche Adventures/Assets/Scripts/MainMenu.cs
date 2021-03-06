﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	private float sHeight;
	private float sWidth;
	private bool showCredits = false;
	private bool moveLeft = false;
	private float speed = .6f;

	public GUIStyle titleStyle;
	public GUIStyle creditsStyle;
	

	// Use this for initialization
	void Start () {
		sHeight = Screen.height;
		sWidth = Screen.width;
	}
	
	// Update is called once per frame
	void Update () {
		if (moveLeft) {
			transform.Translate(-speed * Time.deltaTime, 0, 0);
				} else {
			transform.Translate(speed * Time.deltaTime, 0, 0);
				}


		if (transform.position.x >= 2.5)
						moveLeft = true;
				else if (transform.position.x <= -2)
						moveLeft = false;

	}

	void OnGUI() {

		if (showCredits == false) {
						GUI.BeginGroup (new Rect (0, 0, sWidth, sHeight));
						GUI.Label (new Rect (0, sHeight / 6, sWidth, sHeight), "Avalanche Adventures", titleStyle);
						if (GUI.Button (new Rect (sWidth / 2 - sWidth / 10, sHeight / 2 - sHeight / 5, sWidth / 5, sHeight / 10), "Arcade")) {
							Application.LoadLevel(1);
						}

						if (GUI.Button (new Rect (sWidth / 2 - sWidth / 10, sHeight / 2, sWidth / 5, sHeight / 10), "Credits")) {
								showCredits = true;
						}
						GUI.EndGroup ();
				} else if (showCredits == true) {

						GUI.BeginGroup (new Rect (0, 0, sWidth, sHeight));
						GUI.Label (new Rect (0, sHeight / 6, sWidth, sHeight), "Credits", titleStyle);
					
						
						string creditsText = "\nProduction: David Laws\nArtwork: Jack Einhorn\nopengameart.org\nMusic: westarmusic.com" +
							"\n\n\n\n______________________\nMGMS Full Sail\nStoryboard Design\n9/21/14";
						GUI.Label (new Rect(0, sHeight/4 + sHeight/15, sWidth, sHeight), creditsText, creditsStyle);
						

						if (GUI.Button (new Rect (sWidth / 2 - sWidth / 10, sHeight - sHeight/15, sWidth / 5, sHeight / 20), "Return")) {
							showCredits = false;
						}
						GUI.EndGroup ();
				}

	}

}
