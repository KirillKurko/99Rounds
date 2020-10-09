using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.SceneManagement;

public class Bar : MonoBehaviour {

    public GameObject bar;
    public int time;

    void Start() {
        AnimateBar();
    }

    void Update() {
        if (bar.transform.localScale.x == 1) {
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }
    }

    public void AnimateBar() {
        LeanTween.scaleX(bar, 1, time);
    }
}
