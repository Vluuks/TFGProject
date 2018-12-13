using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    Animator doorAnim;
    float animTime;
    string animName = "DoorOpen";

    void Start()
    {
        doorAnim = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        animTime = Mathf.Clamp01(doorAnim.GetCurrentAnimatorStateInfo(0).normalizedTime);
        doorAnim.Play(animName, 0, animTime);
        doorAnim.SetFloat("Direction", 1.0f);

    }

    public void CloseDoor()
    {
        animTime = Mathf.Clamp01(doorAnim.GetCurrentAnimatorStateInfo(0).normalizedTime);
        doorAnim.Play(animName, 0, animTime);
        doorAnim.SetFloat("Direction", -1.0f);
    }

    public IEnumerator DelayDoor(float delayTime)
    {
        Debug.Log("DelayDoor reached");
        yield return new WaitForSeconds(delayTime);
        Debug.Log("DelayDoor reached2");
        OpenDoor();
    }

    //private void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.T)){
    //        Debug.Log("T key pressed");
    //        //DelayDoor(1);
    //        OpenDoor();
    //    }        
    //}
}
