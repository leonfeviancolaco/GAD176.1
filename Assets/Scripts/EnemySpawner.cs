using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float time;
    [SerializeField] private GameObject mammothPrefab;
    [SerializeField] private GameObject cheetahPrefab;
    List<Enemies> typesenemies = new List<Enemies>();
    void Start()
    { 
        typesenemies.Add(new Mammoth());
        typesenemies.Add(new Cheetah());
    }
        
    void Update()
    {
        time += Time.deltaTime;
        if (time > 10.0f)
        {
            int x = Random.Range(1, 3);
            if (x == 1)
            {
                Instantiate(mammothPrefab, new Vector2 (-7 , 3) , Quaternion.identity);
                typesenemies[0].spawnMessage();
                time = 0f;               
            }
            if (x == 2)
            {
                Instantiate(cheetahPrefab, new Vector2(-7 , 3), Quaternion.identity);
                typesenemies[1].spawnMessage();
                time = 0f;
            }
        }
    }
}
