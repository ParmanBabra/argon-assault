using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    [SerializeField] float destructorDelay;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destructorDelay);
    }
}
