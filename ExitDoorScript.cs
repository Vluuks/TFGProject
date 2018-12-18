using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitDoorScript : MonoBehaviour {

	public Text messageText;
	public PickupTrackerScript pickupTrackerScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	// When player collides with the door
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag("Player")) {
			Debug.Log("player touches exit door");

			//check if player is in posession of key
			// other.gameObject.GetComponent<PickupTrackerScript>().chestKey == true
			if(pickupTrackerScript.levelExitKey) {
				Debug.Log("can open exit");

				messageText.text = "You open the exit door.";
				Invoke("RemoveText", 5f);


				// go to next level
				SceneManager.LoadScene(3);
				
			}
			else {
				messageText.text = "You need a key to open this door.";
				Invoke("RemoveText", 5f);
			}
		}
	}

    void RemoveText() {
        messageText.text = "";
    }
}
