using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(31,0,0);
    public float startDelay = 1.0f;
    public float repeatRate = 3.0f;
    private Player_Controller playerContollerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerContollerScript = GameObject.Find("Player").GetComponent<Player_Controller>();
       
    }

   
    void SpawnObstacle()
    {
        if (playerContollerScript.isGameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
