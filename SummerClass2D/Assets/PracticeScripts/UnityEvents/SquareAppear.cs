using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareAppear : MonoBehaviour
{

    [SerializeField] private GameObject mySquare;

    public void ActivateSquare()
    {
        mySquare.SetActive(true);
    }

    public void ActivateCircle()
    {
        Debug.Log("It's not a sphere :/")
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
