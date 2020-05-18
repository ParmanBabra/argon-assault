using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] PathCreation.PathCreator path;
    [SerializeField] float speed = 5;

    float distanceTravelled;

    float startTime;

    bool isDeath = false;


    // Start is called before the first frame update
    void OnPlayerDeath()
    {
        isDeath = true;
        print("Player Death");
    }

    // Update is called once per frame
    void Update()
    {
        if (isDeath)
            return;
        distanceTravelled += speed * Time.deltaTime;
        transform.position = path.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = path.path.GetRotationAtDistance(distanceTravelled);
    }
}
