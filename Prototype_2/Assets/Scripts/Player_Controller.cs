using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed = 20.0f;
    public float hInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed);

        //Constraints on player movements on the x axis
        if(transform.position.x < -14)
        {
            transform.position = new Vector3(-14, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 14)
        {
            transform.position = new Vector3(14, transform.position.y, transform.position.z);
        }

    }
}
