using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {
	
	public static bool morreu;
	Text gameOver;

	// Use this for initialization
	void Start () {
		morreu = false;
		gameOver = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (morreu && ScoreScript.scoreValue < 402){
			gameOver.text = "GAMEOVER";
			if (Input.GetKey ("r"))
				Application.LoadLevel(Application.loadedLevel);
		}
	}
}
