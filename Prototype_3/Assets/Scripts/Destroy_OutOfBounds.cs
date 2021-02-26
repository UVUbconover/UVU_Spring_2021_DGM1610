using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_OutOfBounds : MonoBehaviour
{
    public Vector3 outOfBounds = new Vector3(-10, 0, 0);
   

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
