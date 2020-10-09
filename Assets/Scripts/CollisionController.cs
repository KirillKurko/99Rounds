using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionController : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag.Equals("player")) {
            Destroy(collider.gameObject);
            Destroy(gameObject);
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }
    }
}
