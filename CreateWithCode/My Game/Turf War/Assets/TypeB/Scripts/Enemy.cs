using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private Rigidbody targetRb;
    private GameManager gameManager;
    
    public ParticleSystem explosionParticle;

    public AudioClip enemySound;
    private AudioSource enemyAudio;
    
    void Start()
    {
        enemyAudio = GetComponent<AudioSource>();
        targetRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            gameManager.GameOver();
        }

    }
}
