using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_OutofBound : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float topBound;
    public float lowerBound;

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
    }
    
    
}
