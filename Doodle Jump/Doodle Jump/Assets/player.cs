﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class player : MonoBehaviour
{
    public float movementSpeed=10f;
    Rigidbody2D rb;
    float movment = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       movment= Input.GetAxis("Horizontal") * movementSpeed;
        
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movment;
        rb.velocity = velocity;

    }
}
