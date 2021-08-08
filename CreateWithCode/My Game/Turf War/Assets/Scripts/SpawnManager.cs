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
        
        StartCoroutine(BigTime());
        GameObject.FindWithTag("Point").SetActive(true);
    }

    IEnumerator BigTime()
    {
        Debug.Log("incoroutine");
        print(Time.time);
        yield return new WaitForSecondsRealtime(20);
        print(Time.time);
    }
}
