using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectiles : MonoBehaviour {
   
	[SerializeField] int numberOfProjectiles;

	[SerializeField] GameObject projectile;

	private Vector2 startPoint;
	private float radius;
    private float moveSpeed;
    private float fireRate;
    private float nextFire;

	void Start () {
		radius = 5f;
		moveSpeed = 2f;
        fireRate = 2f;
        nextFire = Time.time;
	}
	
	void Update () {
		CheckTimeToFire();
	}

    private void CheckTimeToFire() {
        if (Time.time > nextFire) {
            startPoint = new Vector2(transform.position.x, transform.position.y); 
			SpawnProjectiles (numberOfProjectiles);
            nextFire = Time.time + fireRate;
        }
    }

	private void SpawnProjectiles(int numberOfProjectiles) {
		float angleStep = 360f / numberOfProjectiles;
		float angle = 0f;

		for (int i = 0; i <= numberOfProjectiles - 1; i++) {
			
			float projectileDirXposition = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
			float projectileDirYposition = startPoint.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

			Vector2 projectileVector = new Vector2(projectileDirXposition, projectileDirYposition);
			Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed;

			var proj = Instantiate(projectile, startPoint, Quaternion.identity);
			proj.GetComponent<Rigidbody2D> ().velocity = new Vector2(projectileMoveDirection.x, projectileMoveDirection.y);

			angle += angleStep;
		}
	}
}
