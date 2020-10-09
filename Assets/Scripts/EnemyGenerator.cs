using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
    
    public GameObject enemy;
    private float randomX;
    private Vector3 spawnPosition;
    public float spawnRate = 2.0f;
    private float nextSpawn = 0.0f;

    void Update() {
        if (Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
            int enemiesAmount = Random.Range(1, 5);
            for (int i = 0; i < enemiesAmount; ++i) {
                GenerateEnemy();
            }
        }
    }

    private void GenerateEnemy() {
        randomX = Random.Range(-2.6f, 2.6f);
        spawnPosition = new Vector3(randomX, transform.position.y, -1);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
}
