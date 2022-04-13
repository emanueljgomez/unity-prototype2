using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Variables
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 28;
    private float spawnPosZ = 25;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2.0f, 4.0f);
    }

    void SpawnAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
