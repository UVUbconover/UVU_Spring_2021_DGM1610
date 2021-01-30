using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Move : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 45.0f;
    public float vInput;
    
   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gathers inputs for controls
        vInput = Input.GetAxis("Vertical");
      
        
        
        //Moves planefroward at a constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Rotates plane to move up and down while moving forward
        transform.Rotate(Vector3.right, turnSpeed * vInput * Time.deltaTime);


    }
}
