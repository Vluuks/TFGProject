using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class ActivateLeverRocksScript : MonoBehaviour {

    public Text messageText;
    public bool switched;
    public GameObject plane;
    public GameObject plane2;

    Animator leverAnim;

    private void Start() {
        switched = false;
        leverAnim = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other) {

        if (other.gameObject.CompareTag("Player")) { 
            messageText.text = "Press E to switch lever";

            if (Input.GetKeyDown(KeyCode.E) && !switched) {
                switched = true;
                leverAnim.SetTrigger("switch");
                StartCoroutine(WaitForAnimation());
                Destroy(plane);
                Destroy(plane2);

            }
        }
    }

    private void OnTriggerExit(Collider other) {
        messageText.text = "";
    }

    public void ResetLever() {
        if (switched) // only reset if already switched before
        {
            leverAnim.SetTrigger("switch");
            switched = false;
        }
    }

    private IEnumerator WaitForAnimation() {
        yield return new WaitForSeconds(1);
    }

}
