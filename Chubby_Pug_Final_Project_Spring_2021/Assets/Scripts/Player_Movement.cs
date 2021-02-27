using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 6f;
    private Rigidbody rb;
    private float movedirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {   //Player Movement Controls
        movedirection = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(movedirection * speed, rb.velocity.y);
 
    }

}
