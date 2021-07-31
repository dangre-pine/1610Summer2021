﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timer;
    private float timeLimit = 1.5f;
    
    void Update()
    {
        timer += Time.deltaTime;
            
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& timer > timeLimit)
        { 
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0;
        }
    }
}
