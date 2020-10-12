using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 10;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<BulletDeletable>() != null)
        {
            Destroy(this.gameObject);
        }
    }
}
