using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private Vector3 spawnPos = new Vector3(112, -3.47f, 10);
    private float startDelay = 1;
    private float spawnInterval = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomCar()
    {
        //Randomly generate car spawn position
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }
}

