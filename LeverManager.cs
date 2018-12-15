using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour {

    public List<GameObject> correctOrder = new List<GameObject>();     private List<GameObject> selectedOrder = new List<GameObject>();     public GameObject bridge;
     public void AddLever(GameObject newLever)     {         selectedOrder.Add(newLever);          int i = 0;         foreach (GameObject lever in selectedOrder)         {             if (correctOrder[i] != lever)
            { //wrong order, reset levers
                ResetLevers();
                break;             }
            else if (CheckEqual(correctOrder, selectedOrder))
            { // correct order completed
                Debug.Log("closing bridge");
                bridge.GetComponent<Animator>().SetTrigger("close");
            }
            i++;         }     }      public void ResetLevers()     {         foreach (GameObject lever in selectedOrder)         {
            lever.GetComponent<ActivateLeverScript>().ResetLever();         }

        selectedOrder.Clear();     }

    bool CheckEqual(List<GameObject> l1, List<GameObject> l2)
    {
        if (l1.Count != l2.Count)
            return false;
        for (int i = 0; i < l1.Count; i++)
        {
            if (l1[i] != l2[i])
                return false;
        }
        return true;
    } 
}
