using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float hInput;

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

        //Jump command
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(transform.position.y <= 1f)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * 325);
            }   
        }

    
    }

}
