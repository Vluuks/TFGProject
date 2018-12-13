using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRockScript : MonoBehaviour {


	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	    /*
        If it collides with player, select a text from the pool and then show it.
        TODO: check for level.
     */
    void OnTriggerEnter(Collider other)
    {

		Debug.Log("woehoe");
		if (other.gameObject.CompareTag("floor")){
			Debug.Log("hmmm");
			// rb.velocity = Vector3.zero;
			Destroy(rb);
		}
	}
}
