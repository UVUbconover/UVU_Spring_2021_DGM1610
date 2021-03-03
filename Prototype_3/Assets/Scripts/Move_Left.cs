using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Left : MonoBehaviour
{
    public float speed = 13;
    private Player_Controller playerControllerScript;
    private float leftbound = -15;

    // Start is called before the first frame update
    void Start()
    {
        //Finds and stores player contoller script for later access
        playerControllerScript = GameObject.Find("Player").GetComponent<Player_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
    
        if (playerControllerScript.isGameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftbound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
