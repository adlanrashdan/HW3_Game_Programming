using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2.0f;

    void Start()
    {
        if (enemyPrefab == null)
        {
            Debug.LogError("enemyPrefab not assigned in EnemySpawn script");
            return;
        }
        InvokeRepeating("SpawnEnemy", 0, spawnInterval);
    }


    void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10));
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

}
