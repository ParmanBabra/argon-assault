using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFx;
    [SerializeField] Transform parent;
    [SerializeField] int scorePoint = 12;

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
        scoreBoard.ScoreHit(scorePoint);
        Instantiate(deathFx, transform.position, Quaternion.identity, parent);
        Destroy(gameObject);
    }
}
