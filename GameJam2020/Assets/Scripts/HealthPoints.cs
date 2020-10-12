using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    public int points = 1;
    public bool isDead = false;

    private void OnCollisionEnter(Collision collision)
    {
        Damageble damageble = collision.collider.GetComponent<Damageble>();
        points -= damageble.damage;

        if (points <= 0)
        {
            isDead = true;
        }
    }
}