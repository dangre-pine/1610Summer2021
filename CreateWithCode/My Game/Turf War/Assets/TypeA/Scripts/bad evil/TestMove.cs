using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
  
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        transform.Translate(Vector2.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
    }
}
