using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
    
    public GameObject upEnemy;
    public GameObject downEnemy;
    public GameObject leftEnemy;
    public GameObject rightEnemy;

    private float upPosition = 2.6f;
    private float leftPosition = -2.6f;

    private double[] timeValues = {3, 2, 2, 2, 2, 2, 2, 2, 1, 2, 1, 2, 1, 2, 1, 2, 0.5, 1, 2, 1, 
                                2, 1, 2, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0.5, 0.5, 2.5, 2.5, 
                                2.5, 0.5, 1, 0.5, 1, 2.5, 0.5, 1, 2.5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 
                                2, 2, 2, 2, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5, 2.5, 1.5, 1.5, 1.5, 
                                1.5, 1.5, 1.5, 2.5, 2, 2, 2, 2, 1, 1, 1};

    private int[] enemiesAmount = {2, 2, 2, 2, 4, 6, 4, 4, 2, 2,
                                    2, 6, 2, 4, 4, 6, 4, 2, 2, 2,
                                    2, 2, 2, 4, 4, 6, 4, 4, 4, 2,
                                    2, 2, 4, 2, 4, 6, 4, 6, 2, 2,
                                    6, 4, 2, 2, 4, 6, 4, 4, 2, 4,
                                    2, 2, 2, 2, 4, 6, 6, 4, 2, 2,
                                    2, 2, 2, 2, 4, 6, 4, 4, 2, 6,
                                    6, 2, 4, 2, 4, 6, 4, 2, 2, 2,
                                    4, 2, 4, 2, 4, 6};

    private double[] enemiesSpeed = {2, 2, 2, 2, 4, 6, 4, 4, 2, 2,
                                    2, 6, 2, 4, 4, 6, 4, 2, 2, 2,
                                    2, 2, 2, 4, 4, 6, 4, 4, 4, 2,
                                    2, 2, 4, 2, 4, 6, 4, 6, 2, 2,
                                    6, 4, 2, 2, 4, 6, 4, 4, 2, 4,
                                    2, 2, 2, 2, 4, 6, 6, 4, 2, 2,
                                    2, 2, 2, 2, 4, 6, 4, 4, 2, 6,
                                    6, 2, 4, 2, 4, 6, 4, 2, 2, 2,
                                    4, 2, 4, 2, 4, 6};
           
    void Start() {
        StartCoroutine(EnemyGeneratorCoroutine());
    }

    private IEnumerator EnemyGeneratorCoroutine() {
        for (int i = 0; i < timeValues.Length; ++i) {
            for (int j = 0; j < enemiesAmount[i] / 2; ++j) {
                GenerateHorizontalOrVertical((float)enemiesSpeed[i]);
            }
            yield return new WaitForSeconds((float)timeValues[i]);
        }
    }

    private void GenerateHorizontalOrVertical(float enemySpeed) {
        float randomValue = Random.value;
        if (randomValue >= 0.5) {
            GenerateVerticalEnemiesMirrored(enemySpeed);
        }
        else {
            GenerateHorizontalEnemiesMirrored(enemySpeed);
        }
    }

    private void GenerateVerticalEnemiesMirrored(float enemySpeed) {
        float randomX = Random.Range(-2.6f, 2.6f);

        GameObject downEnemyInstance = Instantiate(downEnemy, new Vector3(randomX, upPosition, -1), Quaternion.identity);
        DownVerticalMovement downEnemyInstanceScript = (DownVerticalMovement) downEnemyInstance.GetComponent("DownVerticalMovement");
        downEnemyInstanceScript.speed = enemySpeed;

        GameObject upEnemyInstance = Instantiate(upEnemy, new Vector3(-randomX, -upPosition, -1), Quaternion.identity);
        UpVerticalMovement upEnemyInstanceScript = (UpVerticalMovement) upEnemyInstance.GetComponent("UpVerticalMovement");
        upEnemyInstanceScript.speed = enemySpeed;
    }

    private void GenerateHorizontalEnemiesMirrored(float enemySpeed) {
        float randomY = Random.Range(-2.6f, 2.6f);

        GameObject rightEnemyInstance = Instantiate(rightEnemy, new Vector3(leftPosition, randomY, -1), Quaternion.identity);
        RightHorizontalMovement rightEnemyInstanceScript = (RightHorizontalMovement) rightEnemyInstance.GetComponent("RightHorizontalMovement");
        rightEnemyInstanceScript.speed = enemySpeed;

        GameObject leftEnemyInstance = Instantiate(leftEnemy, new Vector3(-leftPosition, -randomY, -1), Quaternion.identity);
        LeftHorizontalMovement lefrEnemyInstanceScript = (LeftHorizontalMovement) leftEnemyInstance.GetComponent("LeftHorizontalMovement");
        lefrEnemyInstanceScript.speed = enemySpeed;
    }
}
