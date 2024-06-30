using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] public Vector2 playerLocation;
    protected new string name;
    Vector2 movement;

    public Rigidbody2D rb;

    void Update()
    {
        // name of the player
        name = "Travis";
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

        transform.Rotate(0.0f, 0.0f, 20.0f);
    }
}
