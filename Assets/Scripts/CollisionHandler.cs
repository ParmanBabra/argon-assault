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
        // Invoke("ResetLevel", loadSenceDelay);

        // if (deathFx != null)
        //     deathFx.SetActive(true);

        // SendMessage("OnPlayerDeath");
        // SendMessageUpwards("OnPlayerDeath");
    }

    void ResetLevel()
    {
        SceneManager.LoadScene(1);
    }
}
