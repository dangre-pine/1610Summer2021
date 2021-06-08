using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    private float coffeeTemperature = 85.0f;
    private float hotLimitTemperature = 70.0f;
    private float coldLimitTemperature = 40.0f;

    // basically, pressing the space bar during a small time window after the scene begins to play will display a new little message.
    
    // Start is called before the first frame update
    void Start()
    {
// it has been a monday :(
// but at least this is kinda cute
    }  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        //If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot!");
        }
        
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold!");
        }

        // if it is neither of those...
        else
        {
            // ... do this.
            print("Coffee is ok I guess...");
        }
    }
}