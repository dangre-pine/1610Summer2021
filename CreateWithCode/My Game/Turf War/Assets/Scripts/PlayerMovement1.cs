using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float moveSpeed = 7f;
 
 
    private Rigidbody2D playerRb;
    private Transform playerRotation;
   
 
    // Use this for initialization
    void Awake()
    {
        playerRotation = GetComponent<Transform>();
        playerRb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       
        ContinuousMovement();
    }
 
    void Update()
    {
        MoveRotation();
    }
 
    public void ContinuousMovement()
    {
       
        playerRb.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime);
       
       
    }
    void MoveRotation()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {          
            playerRotation.rotation = Quaternion.Euler(0f, 180f, 0f);            
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {  
            playerRotation.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {      
            playerRotation.rotation = Quaternion.Euler(0f, -90f, 0f);                      
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerRotation.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
    }
}
