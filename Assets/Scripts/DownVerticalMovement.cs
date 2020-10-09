using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownVerticalMovement : MonoBehaviour {

    private Rigidbody2D rigidbody;
    public float speed;
    
    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (transform.position.y >= 2.6) {
            Destroy(gameObject);
        }
        MoveDown();
    }

    private void MoveDown() {
        rigidbody.velocity = -transform.up * speed;
    }
}
