using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float bulletSpeed = 10;
    public float reloadTime = 3;
    public Rigidbody bullet;

    private float currentReloadingTime = 0;

    void Update()
    {
    }

    private void FixedUpdate()
    {
        currentReloadingTime += Time.deltaTime;
        if (currentReloadingTime < reloadTime) { return; }

        if (Input.GetButtonDown("Fire1"))
        {
            currentReloadingTime = 0;
            Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
            bulletClone.useGravity = true;
            bulletClone.velocity = transform.forward * bulletSpeed;
        }
    }
}
