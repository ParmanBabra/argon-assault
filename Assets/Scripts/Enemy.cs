using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        var collider = GetComponent<Collider>();
        collider.isTrigger = false;
    }
    
    void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}
