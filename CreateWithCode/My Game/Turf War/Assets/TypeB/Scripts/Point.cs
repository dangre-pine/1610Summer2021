using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    private Rigidbody rb;
    private GameManager gameManager;
    public int pointValue;
    public GameObject grassExplosionFx;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.name == "Player")
        {
           // if (gameManager.isGameActive)
            //{
                // Debug.Log("collison");
                Destroy(gameObject);
                gameManager.UpdateScore(pointValue);
                GrassExplode();
            //}
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void GrassExplode()
    {
        Instantiate(grassExplosionFx, transform.position, grassExplosionFx.transform.rotation);
    }
    
}
