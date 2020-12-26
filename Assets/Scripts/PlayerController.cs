using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    
    private int health;
    public GameObject firstHealth;
    public GameObject secondHealth;
    public GameObject thirdHealth;
    public GameObject fourthHealth;
    public GameObject fifthHealth;


    public void Start() {
        health = 5;
    }
 
    public void decrementHealth() {
        --health;
        switch (health) {
            case 4:
                Destroy(fifthHealth);
                break;
            case 3:
                Destroy(fourthHealth);
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
}
