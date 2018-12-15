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
	public int coinsInThisLevel = 12;
	public int coinCounter;
	private int wishIndex;
	
	public bool levelExitKey;
	public bool chestKey;

	// Use this for initialization
	void Start () {

		wishIndex = 0;
		coinCounter = 0;
		levelExitKey = false;
		chestKey = false;

		scoreText.text = coinCounter.ToString() + "/" + coinsInThisLevel;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateCoinCount() {
		coinCounter++;
		wishIndex++;
		Debug.Log(wishIndex);

		scoreText.text = coinCounter.ToString() + "/" + coinsInThisLevel;
	}

	public void UpdateLevelKeyState() {
		levelExitKey = true;
	}

	public void UpdateChestKeyState() {
		chestKey = true;
	}

	public int GetWishIndex() {
		return wishIndex;
	}

	
}
