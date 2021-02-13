using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float SpawnLimitXLeft = 6;
    private float SpawnLimitXRight = -30;
    private float SpawnPosY = 20;

    private float startDelay = 1.0f;
    private float spawnInterval = 5.0f;
    
    

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval = Random.Range(3, 5));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        int index = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnLimitXLeft, SpawnLimitXRight), SpawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);

       
    }

}

