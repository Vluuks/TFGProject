using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUpManagerList : MonoBehaviour {

    // reference to game text object
    public Text wishText;
    public AudioClip sound;
    public AudioSource src;

    // reference to script that manages pickups globally
    public PickupTrackerScript pickupTrackerScript;
    
    // List of wishes
    private List<string> list = new List<string>() {
        "I want world peace",
        "I want my daughter to recover from her illness",
        "I want my mother to find happiness again",
        "I want eternal youth",
        "I want a home of my own",
        "I want want super powers",
        "I want want to live happily",
        "I want want unlimited funding for education",
        "I want my dog to live as long as I do",
        "I want my epilepsy to go away",
        "I want to always wake up refreshed",
        "I want to be skinny again",
        "I want the ability to shapeshift",
        "I want all pets to have a home",
        "I want new shoes",
        "I want fresh water for everybody",
        "I want to be able to teleport",
        "I want a really cool hat",
        "I want to be reborn as a girl",
        "I want to be able to talk to my pets",
        "I want everyone to be a good person",
        "I want a long fulfilling life",
        "I want my crush to like me back",
        "I want a cure for Alzheimer's",
        "I want to find my soulmate",
        "I want to pay off my student loan debt",
        "I want a hug",
        "I want some ice cream",
        "I want vision in my left eye",
        "I want to have good grades",
        "I want to understand every language",
        "I want my partner to overcome his depression"

    };

    // Init empty
    private void Start() {
        wishText.text = "Find all the wishing well coins!";
        Invoke("RemoveText", 5f);

        src.playOnAwake = false;
        src.clip = sound;
    }

    /*
        If it collides with player, select a text from the pool and then show it.
        TODO: check for level.
     */
    void OnTriggerEnter(Collider other) {

        if (other.gameObject.CompareTag("Player")) {
            
            
            src.Play();
            
            

            wishText.text = list[pickupTrackerScript.GetWishIndex()];
            Invoke("RemoveText", 5f);

            pickupTrackerScript.UpdateCoinCount();
            gameObject.SetActive(false);
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
