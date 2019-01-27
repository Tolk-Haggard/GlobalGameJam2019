using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject [] enemy;
    public Transform [] enemyStart;
    int randomSpawnPoint;
    int enemiesOnScreen;
    int randomSpawnMonster;
    float timer = 0.0f;
    float minTime = 3.0f;
    float maxTime = 10.0f;

    void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }
    


    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            SpawnMonster();
            timer = Random.Range(minTime, maxTime);
        }
    }

    void SpawnMonster()
    {
        randomSpawnMonster = Random.Range(0, enemy.Length);
        randomSpawnPoint = Random.Range(0, enemyStart.Length);
        Instantiate(enemy[randomSpawnMonster], enemyStart[randomSpawnPoint].position, enemyStart[randomSpawnPoint].rotation);
    }
}
