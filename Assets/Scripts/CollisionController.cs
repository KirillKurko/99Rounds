using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag.Equals("player")) {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
