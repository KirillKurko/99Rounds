using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    void Update() {
        if (Mathf.Abs(transform.position.x) >= 2.6 || Mathf.Abs(transform.position.y) >= 2.6) {
            Destroy(gameObject);
        }
    }
}
