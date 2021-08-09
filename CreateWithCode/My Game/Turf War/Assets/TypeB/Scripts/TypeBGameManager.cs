using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class TypeBGameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI timerCountdown;
    public GameObject titleScreen;
    public Button restartButton;
    
    private int score;
    //private float timer;
    public bool isGameActive;
    
    public GameObject[] pointPrefab;
    public GameObject[] enemyPrefab;
    private float spawnPosX = 11;
    private float spawnRangeY = 4;
    private float startDelay = 2;
    private float pointSpawnInterval = 0.5f;
    private float enemySpawnInterval = 2.0f;
    
    void Start()
    {
        InvokeRepeating("SpawnPoints", startDelay, pointSpawnInterval);
        InvokeRepeating("SpawnEnemys", startDelay, enemySpawnInterval);
    }
    
    // Start is called before the first frame update
    //public void StartGame(int difficulty)
    //{
        //pointSpawnInterval /= difficulty;
        //enemySpawnInterval /= difficulty;
       // isGameActive = true;
       // StartCoroutine(SpawnPoints());
        //StartCoroutine(SpawnEnemys());
        
        //score = 0;
        //timer = 60;
       // UpdateScore(0);
        //titleScreen.SetActive(false);
   // }

    // Update is called once per frame
    private void Update()
    {
       // if (isGameActive == true)
       // {
            //CountdownTimer();
       // }

       // if (timer < 0)
       // {
        //    GameOver();
       // }
    }

    void SpawnPoints()
    {
        //while (isGameActive)
        //{
            //yield return new WaitForSeconds(pointSpawnInterval);
            int pointIndex = Random.Range(0, pointPrefab.Length);
            Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(-spawnRangeY, spawnRangeY), 0);

            //if (isGameActive)
          //  {
                Instantiate(pointPrefab[pointIndex], spawnPos, pointPrefab[pointIndex].transform.rotation);
           // }
        //}
    }

    IEnumerator SpawnEnemys()
    {
        //while (isGameActive)
       // {
            Debug.Log("what the heck");
            yield return new WaitForSeconds(enemySpawnInterval);
            int enemyIndex = Random.Range(0, enemyPrefab.Length);
            Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(-spawnRangeY, spawnRangeY), 0);
           // if (isGameActive)
           // {
                Instantiate(enemyPrefab[enemyIndex], spawnPos, enemyPrefab[enemyIndex].transform.rotation);
           // }
        //}
    }
    
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    //public void CountdownTimer()
    //{
    //    timer -= Time.deltaTime;
     //   timerCountdown.text = "Time: " + Mathf.Round(timer);
    //}
    
    //public void GameOver()
    //{
    //    gameOverText.gameObject.SetActive(true);
    //    restartButton.gameObject.SetActive(true);
     //   isGameActive = false;
   // }

    // Restart game by reloading the scene
   // public void RestartGame()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   // }

}
