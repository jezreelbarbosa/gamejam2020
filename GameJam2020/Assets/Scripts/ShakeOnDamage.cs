using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeOnDamage : MonoBehaviour
{
    public float shakeMagnetude = 0.05f;
    public float shakeTime = 0.5f;

    private Vector3 initialPosition;
    private HealthPoints healthPoints;
    private int lastHealthPoint;

    public void ShakeIt()
    {
        initialPosition = transform.position;
        InvokeRepeating("StartShaking", 0f, 0.005f);
        Invoke("StopShaking", shakeTime);
    }

    void StartShaking()
    {
        float shakingOffsetX = Random.value * shakeMagnetude * 2 - shakeMagnetude;
        float shakingOffsetY = Random.value * shakeMagnetude * 2 - shakeMagnetude;
        Vector3 intermadiatePosition = transform.position;
        intermadiatePosition.x += shakingOffsetX;
        intermadiatePosition.y += shakingOffsetY;
        transform.position = intermadiatePosition;
    }

    void StopShaking()
    {
        CancelInvoke("StartShaking");
        transform.position = initialPosition;
    }

    void Start()
    {
        healthPoints = GetComponent<HealthPoints>();
        lastHealthPoint = healthPoints.points;
    }

    void Update()
    {
        if (lastHealthPoint != healthPoints.points)
        {
            lastHealthPoint = healthPoints.points;
            ShakeIt();
        }
    }
}
