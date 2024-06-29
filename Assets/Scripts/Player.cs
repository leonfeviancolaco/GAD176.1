using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int health = 5;
    [SerializeField] private float speed = 5.0f;
    [SerializeField] public Vector2 playerLocation;

    void Start()
    {
        

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {


        }
    }
}
