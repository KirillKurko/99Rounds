using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMove : MonoBehaviour {

    private Rigidbody2D rigidbody;
    private float deltaX;
    private float deltaY;
    
    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            switch (touch.phase) {
                case TouchPhase.Began:
                    deltaX = touchPosition.x - transform.position.x;
                    deltaY = touchPosition.y - transform.position.y;
                    break;
                case TouchPhase.Moved:
                    float x = Mathf.Clamp(touchPosition.x - deltaX, -2.4f, 2.4f);
                    float y = Mathf.Clamp(touchPosition.y - deltaY, -2.4f, 2.4f);
                    rigidbody.MovePosition(new Vector2(x, y));
                    break;
                case TouchPhase.Ended:
                    rigidbody.velocity = Vector2.zero;
                    break;
            }  
        }
    }
}
