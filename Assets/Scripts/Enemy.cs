using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFx;

    [SerializeField] Transform parent;
    void Start()
    {
        var collider = GetComponent<Collider>();
        collider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        Instantiate(deathFx, transform.position, Quaternion.identity, parent);
        Destroy(gameObject);
    }
}
