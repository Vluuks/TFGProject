using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour {

    public static MainGameManager instance;

    Animator doorAnim;
    float animTime;
    string animName = "DoorOpen";


    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start()
    {
        doorAnim = GameObject.FindWithTag("exit").GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        animTime = Mathf.Clamp01(doorAnim.GetCurrentAnimatorStateInfo(0).normalizedTime);
        doorAnim.Play(animName, 0, animTime);
        doorAnim.SetFloat("direction", 1.0f);
    }

    public void CloseDoor()
    {
        animTime = Mathf.Clamp01(doorAnim.GetCurrentAnimatorStateInfo(0).normalizedTime);
        doorAnim.Play(animName, 0, animTime);
        doorAnim.SetFloat("direction", -1.0f);
    }

    public IEnumerator DelayDoor(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Debug.Log("DelayDoor reached");
        OpenDoor();
    }

}
