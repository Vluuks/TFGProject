using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class ActivateLeverScript : MonoBehaviour {

    public Text messageText;
    public bool switched;
    public GameObject leverManager;

    Animator leverAnim;

    private void Start()
    {
        switched = false;
        leverAnim = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        messageText.text = "Press E to switch lever";
        if (Input.GetKeyDown(KeyCode.E) && !switched)
        {
            switched = true;
            leverAnim.SetTrigger("switch");
            leverManager.GetComponent<LeverManager>().AddLever(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        messageText.text = "";
    }

    public void ResetLever()
    {
        if (switched) // only reset if already switched before
        {
            leverAnim.SetTrigger("reset");
            switched = false;
        }
    }



}
