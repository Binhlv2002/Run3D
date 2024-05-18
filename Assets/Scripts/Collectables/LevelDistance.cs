using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelDistance : MonoBehaviour
{
    public GameObject distanceDisplay;
    public GameObject distanceOverDisplay;
    public int distanceRun;
    public bool addingDistance = false;

    void Update()
    {
        if(addingDistance == false)
        {
            addingDistance = true;
            StartCoroutine(AddingDistance());

        }    
    }

    IEnumerator AddingDistance()
    {
        distanceRun += 1;
        distanceDisplay.GetComponent<TextMeshProUGUI>().text = "" + distanceRun;
        distanceOverDisplay.GetComponent<TextMeshProUGUI>().text = "" + distanceRun;
        yield return new WaitForSeconds(0.35f);
        addingDistance = false;
    }
}
