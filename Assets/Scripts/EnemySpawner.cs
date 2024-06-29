using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float time = Time.deltaTime;
    public float mammothspeed = 2.0f;
    public float cheetahspeed = 4.0f;
    [SerializeField] private GameObject mammothPrefab;
    [SerializeField] private GameObject cheetahPrefab;
    float x = -7;
    float y = 3;
    void Start()
    {
        List<Enemies> typesenemies = new List<Enemies>();
        typesenemies.Add(new Mammoth());
        typesenemies.Add(new Cheetah());
        
    }

    void Update()
    {
        if (time == 64.0f)
        {
            int x = Random.Range(1, 3);
            if (x == 1)
            {
                Instantiate(mammothPrefab, new Vector2 (x,y) , Quaternion.identity);
              
                time = 0f;
            }
            if (x == 2)
            {
                Instantiate(cheetahPrefab, new Vector2(x, y), Quaternion.identity);
                time = 0f;
            }
        }
    }
}
