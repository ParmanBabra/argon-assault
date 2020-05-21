using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DefenderController : MonoBehaviour
{
    [SerializeField] GameObject gun;
    [SerializeField] float rotation;

    private void Update()
    {
        gun.transform.rotation = Quaternion.Euler(0, rotation, 0);
    }
}
