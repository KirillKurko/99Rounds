using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHorizontalMovement : MonoBehaviour {

    private Rigidbody2D rigidbody;
    public float speed;
    
    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (transform.position.x <= -2.6) {
            Destroy(gameObject);
        }
        MoveLeft();
    }

    private void MoveLeft() {
        rigidbody.velocity = -transform.right * speed;
    }
}
