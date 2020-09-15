using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMove : MonoBehaviour {
    
    private Vector3 touchPosition;
    private Rigidbody2D rigidbody;
    private Vector3 direction;
    private float moveSpeed = 10f;
    
    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touchPosition);
            touchPosition.z = 0;
            direction = touchPosition - transform.position;
            rigidbody.velocity = new Vector2(direction.x, direction.y) * moveSpeed;

            if (touch.Phase == TouchPhase.Ended) {
                rigidbody.velocity = Vector2.zero;
            }
        }
    }
}
