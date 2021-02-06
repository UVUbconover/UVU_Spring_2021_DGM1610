using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_OutofBound : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float topBound = 35;
    public float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); }

        if (transform.position.z < lowerBound){
            Destroy(gameObject);
        }
    }
    
    
}
