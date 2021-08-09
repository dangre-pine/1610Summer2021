using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private void Start()
    {
      
        
    }

    private void Update()
    {
        if (GameObject.FindWithTag("Row 1 Point 3") != null)
        {
            Debug.Log("TAG FOUND !!!!!!!!!!");
            StartCoroutine(BigTime());
            Debug.Log("Back From Co Routine");
            Debug.Log("Object Status " + GameObject.FindWithTag("Row 1 Point 3").activeSelf);
            //GameObject.FindWithTag("Row 1 Point 3").SetActive(true);
            Debug.Log("Object Status After " + GameObject.FindWithTag("Row 1 Point 3").activeSelf);
        }
        else
        {
            Debug.Log("TAG NOT FOUND XXXXXXXXX");
        }
    }

    IEnumerator BigTime()
    {
        Debug.Log("incoroutine");
        print(Time.time);
        yield return new WaitForSecondsRealtime(20);
        print(Time.time);
    }
}
