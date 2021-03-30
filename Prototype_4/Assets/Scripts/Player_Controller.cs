using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody playerRb;
    private GameObject focalPoint;

    public bool hasPowerUp;
    public float powerupStrength = 16.0f;

    public GameObject powerupIndicator;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * Time.deltaTime);
        powerupIndicator.transform.position = transform.position + new Vector3 (0, 0.5f, 0);
    }

    // This block of code allows player to pick up power ups. The power ups are removed from game.
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            Debug.Log("Power Up Collected");

            StartCoroutine(PowerupCountdownRoutine());

            powerupIndicator.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            //Gets access to the enemies Rigidbody so we can access its physical properties.
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            //Gets the position of player and enemy for power up effect, meaning the enemy gets pushed away.
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);

            //Reports player collisions with powerups and enemies.
            Debug.Log("Player has collided with " + collision.gameObject + "with powerup set to " + hasPowerUp);

            //When player collides with enemy while using a powerup the enemy is pushed away by adding force.
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(8); hasPowerUp = false;
        powerupIndicator.gameObject.SetActive(false);
    }

}
