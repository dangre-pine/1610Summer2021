using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSpawn : MonoBehaviour
{

    public GameObject pointPrefab;
   public int creditValue = 1;
   public IntData numberCount;
   public Text counterText;
   public Renderer rend;

    // Start is called before the first frame update
    private void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        numberCount.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   // void 
        public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.name == "Player")
        {
            Destroy(gameObject);
       // {
            // get current score and add the credit value to it
           // numberCount.value += creditValue;
            // set the text object equal to the score
           // counterText.text = numberCount.value.ToString();
           // Debug.Log("*****" + numberCount.value);
            // set game object to false so it disapears
           // rend.enabled = false;
           // int wait_time = 5;
           // yield return new WaitForSeconds(wait_time);
           // rend.enabled = true;
        }

        StartCoroutine(PointCountdownRoutine());
    }

   IEnumerator PointCountdownRoutine()
    {
       yield return new WaitForSeconds(5);
       rend.enabled = true;
    }
    
}


