using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private float rotationSpeed = 500.0f;
    
    void Update()
    {
        // determines how propeller spins
        // attempt: transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime); ,, incorrect
        transform.Rotate(Vector3.back * Time.deltaTime * rotationSpeed);
    }
}
