using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Rigidbody rb;
    private GameManager gameManager;
    private AudioSource audioSource;
    public AudioClip pointSound;
    
    public float verticalInput;
    public float speed = 20.00f;
    public float yRange = 4.50f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

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
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Point")
        {
            if (gameManager.isGameActive)
            {
                audioSource.PlayOneShot(pointSound, 1.0f);
            }
        }
    }
}
