using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
    
    public GameObject enemy;
    private float randomX;
    private Vector3 spawnPosition;
    public float spawnRate = 2.0f;

    void Start() {
        StartCoroutine(EnemyGeneratorCoroutine());
    }

    private IEnumerator EnemyGeneratorCoroutine() {
        while (true) {
            GenerateEnemies();
            yield return new WaitForSeconds(Mathf.Lerp(0.5f, 2.0f, Random.value));
        }
    }

    private void GenerateEnemies() {
        int enemiesAmount = Random.Range(1, 3);
        for (int i = 0; i < enemiesAmount; ++i) {
            GenerateEnemy();
        }
    }

    private void GenerateEnemy() {
        randomX = Random.Range(-2.6f, 2.6f);
        spawnPosition = new Vector3(randomX, transform.position.y, -1);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
}
