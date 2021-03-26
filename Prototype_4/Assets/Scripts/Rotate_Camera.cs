﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Camera : MonoBehaviour
{
    public float rotateSpeed;

  

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotateSpeed * Time.deltaTime);
    }
}
