using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha = 5;
    private int beta = 0;
    private int gamma = 5;
    public AnotherClass myOtherClass;

    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;
        
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.peaches);
    }

    void Example(int pencils, int markers)
    {
        int answer;
        answer = markers * pencils * alpha;
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}


