using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    
    private int health;

    public void Start() {
        health = 3;
    }

    public void Update() {
        if (health == 0) {
            Destroy(gameObject);
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }
    }

    public void decrementHealth() {
        --health;
    }
}
