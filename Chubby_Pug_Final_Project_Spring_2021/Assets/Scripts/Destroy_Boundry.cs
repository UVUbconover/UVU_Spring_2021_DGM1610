using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Boundry : MonoBehaviour
{
    public Vector3 outOfBounds = new Vector3(-4.71f, -3.47f, 10);

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
