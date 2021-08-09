using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float leftBound = -12;
    //private float rightBound = 12;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        
        //else if (transform.position.z < rightBound)
       // {
        //    Destroy(gameObject);
       // }
    }
}
