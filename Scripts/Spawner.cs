 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;

    public float timeBetweenSpawns;
    float nextSpawnTime;
    void Start()
    {
        
    }

    void Update()
    {
       if(Time.time > nextSpawnTime)
        {
            Instantiate(enemy, spawnPoints[Random.Range(0,spawnPoints.Length)].position,Quaternion.identity); //spawnlamak i�in instantiate'e ihtiyac�m�z var
            nextSpawnTime= Time.time + timeBetweenSpawns;
        }
    }
}
