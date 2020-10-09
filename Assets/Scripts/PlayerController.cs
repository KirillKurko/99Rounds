using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    
    private int health;
    public GameObject firstHealth;
    public GameObject secondHealth;
    public GameObject thirdHealth;

    public void Start() {
        health = 3;
    }

    public void Update() {
        switch (health) {
            case 3:
                break;
            case 2:
                Destroy(thirdHealth);
                break;
            case 1:
                Destroy(secondHealth);
                break;
            case 0:
                Destroy(firstHealth);
                Destroy(gameObject);
                Scene scene = SceneManager.GetActiveScene(); 
                SceneManager.LoadScene(scene.name);
                break;
        }
    }

    public void decrementHealth() {
        --health;
    }
}
