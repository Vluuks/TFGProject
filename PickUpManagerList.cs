using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUpManagerList : MonoBehaviour {

    // reference to game text object
    public Text wishText;

    // reference to script that manages pickups globally
    public PickupTrackerScript pickupTrackerScript;
    
    // List of wishes
    private List<string> list = new List<string>() {
        "I want world peace",
        "I want my daughter to recover from her illness",
        "I want my mother to find happiness again",
        "I want 4",
        "I want 5",
        "I want 6",
        "I want 7",
        "I want 8",
        "I want 9",
        "I want 10",
        "I want 11",
        "I want 12"
    };

    // Init empty
    private void Start() {
        wishText.text = "Find all the wishing well coins!";
        Invoke("RemoveText", 5f);
    }

    /*
        If it collides with player, select a text from the pool and then show it.
        TODO: check for level.
     */
    void OnTriggerEnter(Collider other) {

        if (other.gameObject.CompareTag("Player")) {
            
            gameObject.SetActive(false);

            wishText.text = list[pickupTrackerScript.GetWishIndex()];
            Invoke("RemoveText", 5f);

            pickupTrackerScript.UpdateCoinCount();
        }
    }


    /*
        Reset text.
     */
    void RemoveText() {
        wishText.text = "";
    }

    /*
        Generates random index within bounds.
     */
    int randListIndex() {
        return Random.Range(0, (list.Count-1)); 
    }

}
