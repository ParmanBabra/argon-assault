using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSceneLoader : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadFirstScene", 2.0f);
    }

    private void LoadFirstScene() => SceneManager.LoadScene(1);
}
