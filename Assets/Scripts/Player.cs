using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField] private int health = 5;
    [SerializeField] private float speed = 5.0f;
    [SerializeField] public Vector2 playerLocation;

    Vector2 movement;

    public Rigidbody2D rb;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}
