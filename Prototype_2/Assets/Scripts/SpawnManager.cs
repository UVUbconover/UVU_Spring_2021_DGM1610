﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float SpawnRangeX = 20;
    private float SpawnPosZ = 30;
    private float startDelay = 1;
    private float spawnInterval = 2.5f;

    // Start is called before the first frame update
    void Start() 
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay,spawnInterval);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        //Randomly generate animal spawn position and animal type
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
