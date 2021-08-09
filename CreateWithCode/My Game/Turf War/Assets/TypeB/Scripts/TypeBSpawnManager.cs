using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeBSpawnManager : MonoBehaviour
{
    public GameObject[] pointPrefab;
    private float spawnPosX = 11;
    private float spawnRangeY = 4;
    private float startDelay = 2;
    private float spawnInterval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPoints", startDelay, spawnInterval);
    }

    void SpawnPoints()
    {
        int animalIndex = Random.Range(0, pointPrefab.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(-spawnRangeY, spawnRangeY), 0);

        Instantiate(pointPrefab[animalIndex], spawnPos, pointPrefab[animalIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
