using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
	Script attached to the player that tracks how many and what
	they have picked up. The counter methods are called upon collision
	with the respective items from those scripts.
 */
public class PickupTrackerScript : MonoBehaviour {

	public Text scoreText;

	// for each level track the things that the player has picked up
	public int coinCounter;
	public int gemCounter;
	public bool levelExitKey;
	public bool chestKey;

	// Use this for initialization
	void Start () {
		coinCounter = 0;
		gemCounter = 0;
		levelExitKey = false;
		chestKey = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateCoinCount() {
		Debug.Log("tracker called");
		coinCounter++;
		Debug.Log(coinCounter);
		scoreText.text = coinCounter.ToString();
	}

	public void UpdateGemCounter() {
		Debug.Log("tracker called");
		gemCounter++;
	}

	public void UpdateLevelKeyState() {
		Debug.Log("tracker called");
		levelExitKey = true;
	}

	public void UpdateChestKeyState() {
		Debug.Log("tracker called");
		chestKey = true;
	}


	
}
