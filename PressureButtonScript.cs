using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureButtonScript : MonoBehaviour {

    Animator buttonAnim;
    public string pressureParam;
    public GameObject buttonManager;
    public bool needsWeight;

	// Use this for initialization
	void Start () {
        buttonAnim = GetComponent<Animator>();
	}

    private void OnTriggerEnter(Collider other)
    {
        buttonAnim.SetTrigger(pressureParam);
        buttonManager.GetComponent<ColorButtonManager>().AddButton(gameObject);

    }

    public void OnTriggerExit(Collider other)
    {
        if (needsWeight)
        {
            buttonAnim.SetTrigger(pressureParam);
            buttonManager.GetComponent<ColorButtonManager>().RemoveButton(gameObject);
        }
    }


}
