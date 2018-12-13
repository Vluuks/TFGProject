using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour {

    Animator buttonAnim;
    public string pushParam;


    // Use this for initialization
    void Start()
    {
        buttonAnim = GetComponent<Animator>();
    }


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            buttonAnim.SetTrigger(pushParam);
            StartCoroutine(GameObject.Find("ButtonWall").GetComponent<DoorScript>().DelayDoor(1.0f));

        }
    }

}
