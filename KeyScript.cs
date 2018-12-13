using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour {

	// Reference to game text object
    public Text messageText;
	public PickupTrackerScript pickupTrackerScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		// if player touches the key
		if (other.gameObject.CompareTag("Player")) {
			Debug.Log("player touches key");

			// set key state to true and remove key
			pickupTrackerScript.UpdateChestKeyState();
			Destroy(gameObject);
		}
	}
}
