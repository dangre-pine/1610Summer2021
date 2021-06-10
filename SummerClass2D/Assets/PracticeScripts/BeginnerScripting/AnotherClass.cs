using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int peaches;
    public int kiwis;

    private int scissors;
    private int tape;

    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
