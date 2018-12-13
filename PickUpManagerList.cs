using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUpManagerList : MonoBehaviour {

    public PickupTrackerScript pickupTrackerScript;

    // List of wishes
    List<string> list = new List<string>()
    {
        "I want world peace",
        "I want my daughter to recover from her illness",
        "I want my mother to find happiness again",
        "I want ....",
        "I want ....",
        "I want ....",
        "I want ....",
        "I want ....",
        "I want ...."
    };


    // Reference to game text object
    public Text wishText;

    // Init empty
    private void Start() {
        wishText.text = "test test";
    }

    /*
        If it collides with player, select a text from the pool and then show it.
        TODO: check for level.
     */
    void OnTriggerEnter(Collider other)
    {

        Debug.Log("collision with coin");
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Debug.Log("isplayer");

            // Obtan wish from list & show
            int wishIndex = randListIndex();
            wishText.text = list[wishIndex];
            Invoke("RemoveText", 5f);

            // Can now be removed
            list.RemoveAt(wishIndex);
            Debug.Log(list.Count);

            pickupTrackerScript.UpdateCoinCount();
        }
    }


    /*
        Reset text.
     */
    void RemoveText()
    {
        wishText.text = "";
    }

    /*
        Generates random index within bounds.
     */
    int randListIndex() {
        return Random.Range(0, (list.Count-1)); 
    }

}
