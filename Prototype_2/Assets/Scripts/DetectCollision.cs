using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Destroy the animal, the script is attatched to
        Destroy(gameObject);
        //Destroy the apple, that hits the animal
        Destroy(other.gameObject);
    }
}
