using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 

    [SerializeField] Vector3 startPoint;
    [SerializeField] Vector3 endPoint;
    [SerializeField] Vector3 normalized;
    [SerializeField] Vector3 final;
    
    float x;
    float y;
    float m;

    float distance;
    float overcame = 0;
    void Start()
    {
        final = startPoint;

        normalized.x = endPoint.x - startPoint.x;
        normalized.y = endPoint.y - startPoint.y;     

        x = normalized.x * normalized.x;
        y = normalized.y * normalized.y;

        m = Mathf.Sqrt(x + y);

        normalized.x = normalized.x / m;
        normalized.y = normalized.y / m;


        distance = Vector3.Distance(startPoint, endPoint);
    }

    void Update()
    {
        if (overcame <= distance)
        {
            overcame += normalized.magnitude;
            final += normalized;
        }
        else
        {
            final = endPoint;
        }

     }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(startPoint, endPoint);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(startPoint, final);
    }
}