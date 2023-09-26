using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody controller;
    public float movementSpeed = 5f;

    Vector3 direction;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direction = new Vector3(horizontal, 0f, vertical).normalized;

    }

    void FixedUpdate()
    {
        controller.velocity = direction * movementSpeed;
    }
}
