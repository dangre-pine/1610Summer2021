using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    
    // message would play when object reaches certain position
    void Start()
    {
        
        // debug.log is what prints the message
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            // basically "im about to hit the ground!"
            Debug.Log("I'm gunna munch, I'm gunna crunch!");
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
