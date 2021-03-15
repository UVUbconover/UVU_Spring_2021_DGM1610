using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float hInput;
    public float movex = -8;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        // Controls player movement foward and backward. Meaning left and right across the screen.
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * hInput);

        //Creates player boundry so that the player can only move to the right.
        if (transform.position.x < movex)
        {
            transform.position = new Vector3(movex, transform.position.y, transform.position.z);
        }

        //Jump command
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(transform.position.y <= 1f)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * 325);
            }   
        }

    
    }

}
