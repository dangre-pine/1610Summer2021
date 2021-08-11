using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private GameManager gameManager;
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Player").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       // if (gameManager.gameOver == false)
        //{
            transform.Translate(Vector3.left * Time.deltaTime * speed);
       // }
        
    }
    
}
