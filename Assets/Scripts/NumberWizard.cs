using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max, min, guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame() {
		max = 1000;
		min = 1;
		guess = 500;
		print ("===========================");
		print ("Number Wizard");
		print ("Pick a number between " + min + " & " + max + ".");
		print ("===========================");
		GameRules();
		max += 1;
	}
	
	void GameRules() {
		guess = (min + max) / 2;
		print ("Is your number lower or higher than " + guess + "?");
		print ("Up Arrow for higher, Down Arrow for lower, Return for right.");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			// print ("Up Arrow Pressed.");
			min = guess;
			GameRules();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			// print ("Down Arrow Pressed.");
			max = guess;
			GameRules();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			// print ("Return Key Pressed.");
			print ("I Win!");
			StartGame();
		}
	}
}
