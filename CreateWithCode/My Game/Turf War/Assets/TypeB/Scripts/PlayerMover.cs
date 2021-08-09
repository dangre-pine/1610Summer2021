using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float verticalInput;
    public float speed = 20.00f;
    public float yRange = 4.50f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
           transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
         //   Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
       // }
    }
}
