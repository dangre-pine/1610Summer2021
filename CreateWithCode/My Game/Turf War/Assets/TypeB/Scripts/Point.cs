using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(AudioSource))]

public class Point : MonoBehaviour
{
    public AudioSource tickSource;
    private Rigidbody rb;
    private GameManager gameManager;
    public int pointValue;
    private AudioSource audioSource;
    
    
   // public GameObject grassExplosionFx;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
       // tickSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.name == "Player")
        {
            if (gameManager.isGameActive)
            {
                Destroy(gameObject);
                gameManager.UpdateScore(pointValue);
                //GrassExplode();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //GrassExplode()
   // {
      //  Instantiate(grassExplosionFx, transform.position, grassExplosionFx.transform.rotation);
    //}
    
}
