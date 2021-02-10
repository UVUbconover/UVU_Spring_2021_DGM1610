using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Forward : MonoBehaviour
{
    private float speed = 13.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
