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

    void Start()
    { }
    


    void Update()
    {
        
    }

    void SpawnMonster()
    {
        randomSpawnMonster = Random.Range(0, enemy.Length);
        randomSpawnPoint = Random.Range(0, enemyStart.Length);
        Instantiate(enemy[randomSpawnMonster], enemyStart[randomSpawnPoint].position, enemyStart[randomSpawnPoint].rotation);
    }
}
