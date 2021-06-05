using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    private int myInt = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        // debug.log prints results
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }
    
    int MultiplyByTwo(int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
