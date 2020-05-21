using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float loadSenceDelay = 1f;
    [SerializeField] GameObject deathFx;
    void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }

    void StartDeathSequence()
    {
        //TESTING
    }

    void ResetLevel()
    {
        SceneManager.LoadScene(1);
    }
}
