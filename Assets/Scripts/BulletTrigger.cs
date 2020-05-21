using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
    private void OnParticleTrigger()
    {
        print("On Particle Trigger");
    }

    private void OnParticleCollision(GameObject other)
    {
        print("On Particle Collision");
    }
}
