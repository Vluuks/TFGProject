using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestScript : MonoBehaviour {

	// Reference to game text object
    public Text messageText;

	// ref to object that needs to be animated
	public GameObject chestTop;

	// ref to script on player
	public PickupTrackerScript pickupTrackerScript;

	// track if chest has already been opened
	private bool hasOpened = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag("Player")) {
			Debug.Log("player touches chest");

			//check if player is in posession of key
			// other.gameObject.GetComponent<PickupTrackerScript>().chestKey == true
			if(pickupTrackerScript.chestKey && !hasOpened) {
				Debug.Log("can open chest");

				messageText.text = "You open the chest.";
				Invoke("RemoveText", 5f);

				// grab the top of the chest and play the animation
				chestTop.GetComponent<Animation>().Play("OpenChest");

				// change variable so that it can not occur again
				hasOpened = true;
			}
			else if(!pickupTrackerScript.chestKey) {
				Debug.Log("cannot open chest");
				messageText.text = "It seems you need a key to open this chest...";
				Invoke("RemoveText", 5f);
			}
		}
	}

    void RemoveText() {
        messageText.text = "";
    }
}
