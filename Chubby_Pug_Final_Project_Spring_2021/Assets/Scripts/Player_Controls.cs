using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    public float speed = 10;
    public float hinput;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hinput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(transform.position.y <= 0f)
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }
    }

    


}

