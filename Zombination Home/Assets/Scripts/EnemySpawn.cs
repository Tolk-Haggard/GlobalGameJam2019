using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

    void Start()
    {
        Instantiate(enemy, new Vector3(Random.Range(-200, 200), Random.Range(-200, 200), 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
