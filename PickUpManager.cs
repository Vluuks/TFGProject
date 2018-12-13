using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUpManager : MonoBehaviour {

    public Text wishText;


    private void Start()
    {
        wishText.text = "";
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            wishText.text = "I want world peace!";
            Invoke("RemoveText", 5f);


        }
    }

    void RemoveText()
    {
        wishText.text = "";

    }

}
