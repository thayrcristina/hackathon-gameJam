using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour {
	
	Text win;

	// Use this for initialization
	void Start () {
		win = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameOverScript.morreu && ScoreScript.scoreValue > 20){
			win.text = "WIN";
			if (Input.GetKey ("r"))
				Application.LoadLevel(Application.loadedLevel);
			if (Input.GetKey (KeyCode.Space))
				Application.LoadLevel("DonkeyKong");
		}
	}
}