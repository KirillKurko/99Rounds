using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour {

    public void Play() {
        SceneManager.LoadScene("MainScene");
    }

    public void Back() {
        SceneManager.LoadScene("MainMenu");
    }
}
