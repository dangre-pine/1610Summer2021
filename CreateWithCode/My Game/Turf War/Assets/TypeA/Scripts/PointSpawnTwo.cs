using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PointSpawnTwo : MonoBehaviour
{
    private Rigidbody rb;
    private GameManager gameManager;
    public int pointValue;
    public GameObject explosionFx;
    public GameObject gameObj;
    public int regenCount = 0;
    public Renderer rend;
    public float regenTime = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        Debug.Log("this is start");

        // gameObj = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        if (!(gameObj.activeSelf))
        {
            if (regenCount == 20)
            {
                gameObj.SetActive(true);
            }
        
            regenCount++;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            rend = GetComponent<Renderer>();
            Debug.Log("this is frustrating");
            Debug.Log("get tag" + gameObject.tag);
            Debug.Log("get name" + gameObject.name);
            Debug.Log("Object Status Before Collision " + GameObject.FindWithTag("Row 1 Point 3").activeSelf);
            gameObject.SetActive(false);
            if (!GameObject.FindWithTag("Row 1 Point 3").activeSelf)
            {
                Debug.Log("WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWw");
            }
            else if (GameObject.FindWithTag("Row 1 Point 3").activeSelf)
            {
                Debug.Log("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh");
            }
            Debug.Log("Object Status After Collision " + GameObject.FindWithTag("Row 1 Point 3").activeSelf);
          // rend.enabled = false;
          //  Debug.Log("this is frustrating");
            //Debug.Log("get tag" + gameObject.tag);
            //Debug.Log("get name" + gameObject.name);
           // regenTime -= Time.deltaTime;
           // if (regenTime < 0)
           // {
           // for (int i = 0; i < 20000; i++)
           // {
           //     Debug.Log("i" + i);
           // }
         //StartCoroutine(BigTime());
        // yield WaitForSeconds(5);  
         Debug.Log("is this working?");
                //rend.enabled = true;
              // gameObject.SetActive(true);
          // }
            //Destroy(gameObject);
            Debug.Log("end of collision");
        }
    }
    
    void Explode ()
    {
        Instantiate(explosionFx, transform.position, explosionFx.transform.rotation);
    }

    IEnumerator BigTime()
    {
        Debug.Log("incoroutine");
        print(Time.time);
        yield return new WaitForSecondsRealtime(20);
        print(Time.time);
    }
}
