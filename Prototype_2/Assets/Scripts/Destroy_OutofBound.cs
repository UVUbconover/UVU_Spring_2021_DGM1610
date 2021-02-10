using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_OutofBound : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float topBound = 35;
    public float lowerBound = -10;

    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); }

        if (transform.position.z < lowerBound){
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
    
    
}
