using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtonManager : MonoBehaviour {

    public GameObject boulder;
    public GameObject stairs;
    public List<GameObject> boulderButtons = new List<GameObject>();
    public List<GameObject> stairsButtons = new List<GameObject>();
    private HashSet<GameObject> selectedButtons = new HashSet<GameObject>();

    private void Awake()
    {
        // stairs should be inactive at start of scene
        stairs.SetActive(false);   
    }

    public void AddButton(GameObject newButton)
    {
        selectedButtons.Add(newButton);

        CheckBoulder();

        CheckStairs();
    }

    public void RemoveButton(GameObject newButton)
    {
        selectedButtons.Remove(newButton);

        CheckBoulder();

        CheckStairs();
    }

    private void CheckBoulder()
    {
        // pressed correct buttons to remove boulder
        if (selectedButtons.SetEquals(boulderButtons))
        {
            boulder.SetActive(false);
        }
        else if (!selectedButtons.SetEquals(boulderButtons))
        {
            boulder.SetActive(true);
        }
    }

    private void CheckStairs()
    {
        // pressed correct buttons to add stairs
        if (selectedButtons.SetEquals(stairsButtons))
        {
            stairs.SetActive(true);
        }
        else if (!selectedButtons.SetEquals(stairsButtons))
        {
            stairs.SetActive(false);
        }
    }


}
