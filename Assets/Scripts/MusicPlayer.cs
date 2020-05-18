using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    void Awake()
    {
        var musicPlayer = FindObjectsOfType<MusicPlayer>();

        if (musicPlayer.Length > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);

    }
}
