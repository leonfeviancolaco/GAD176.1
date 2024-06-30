using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;

    //Find player's position
    void Start()
    {
        target = FindObjectOfType<Player>().transform;
    }

    void Update()
    {
        var sub = target.position - transform.position;

        transform.up = Vector3.MoveTowards(transform.up, sub , rotationSpeed * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.up, moveSpeed * Time.deltaTime);

        Deathchecker();
    }


    //action when enemy near enough to player
    public virtual void Deathchecker()
    {
        if (Vector3.Distance(transform.position, target.position) <= 2)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }
    }
}