using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("General")]
    [SerializeField] float speed = 20f;
    [SerializeField] float limitX = 13f;
    [SerializeField] float limitY = 13f;

    [Header("Screen-Position Based")]
    [SerializeField] float positionPitchFactor = -1.5f;
    [SerializeField] float positionYewFactor = 2f;

    [Header("Screen-Control Based")]
    [SerializeField] float controlPitchFactor = -25f;
    [SerializeField] float controlRollFactor = -50f;

    [SerializeField] GameObject[] guns;

    float xThrow, yThrow;

    bool isControlEnable = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isControlEnable)
            return;

        ProcessingTranslation();
        ProcessingRoatation();
        ProcessingFiring();
    }

    void OnPlayerDeath()
    {
        isControlEnable = false;
    }

    private void ProcessingRoatation()
    {
        float pitchDueToPosition = transform.localPosition.y * positionPitchFactor;
        float pitchDueToControlThrow = yThrow * controlPitchFactor;
        float pitch = pitchDueToPosition + pitchDueToControlThrow;

        float yaw = transform.localPosition.x * positionYewFactor;

        float roll = xThrow * controlRollFactor;

        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    private void ProcessingTranslation()
    {
        xThrow = Input.GetAxis("Horizontal");
        yThrow = Input.GetAxis("Vertical");

        var deltaOffsetX = xThrow * speed * Time.deltaTime;
        var deltaOffsetY = yThrow * speed * Time.deltaTime;

        var newOffsetX = transform.localPosition.x + deltaOffsetX;
        var newOffsetY = transform.localPosition.y + deltaOffsetY;

        newOffsetX = Mathf.Clamp(newOffsetX, -limitX, limitX);
        newOffsetY = Mathf.Clamp(newOffsetY, -limitY, limitY);

        transform.localPosition = new Vector3(newOffsetX, newOffsetY, transform.localPosition.z);
    }

    private void ProcessingFiring()
    {
        if (!Input.GetButton("Fire1"))
            DeactiveGuns();
        else
            ActiveGuns();
    }

    private void ActiveGuns()
    {
        foreach (var item in guns)
            item.SetActive(true);
    }

    private void DeactiveGuns()
    {
        foreach (var item in guns)
            item.SetActive(false);
    }
}
