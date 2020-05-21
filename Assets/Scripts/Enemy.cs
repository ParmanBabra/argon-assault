using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFx;
    [SerializeField] Transform parent;
    [SerializeField] int scorePoint = 12;
    [SerializeField] int hits = 3;


    ScoreBoard scoreBoard;
    void Start()
    {
        SetupCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void SetupCollider()
    {
        var collider = GetComponent<Collider>();
        collider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        hits--;

        if (hits <= 0)
        {
            scoreBoard.ScoreHit(scorePoint);
            KillEnemy();
        }

    }

    private void KillEnemy()
    {
        Instantiate(deathFx, transform.position, Quaternion.identity, parent);
        Destroy(gameObject);
    }
}
