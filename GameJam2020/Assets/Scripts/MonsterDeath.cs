using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDeath : MonoBehaviour
{
    public float speed = 1;

    private HealthPoints healthPoints;
    private bool isDestroyTriggered = false;
    
    void Start()
    {
        healthPoints = GetComponent<HealthPoints>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPoints.isDead)
        {
            if (!isDestroyTriggered)
            {
                isDestroyTriggered = true;
                Destroy(gameObject, 5);
            }

            transform.position = transform.position + new Vector3(0, -speed * Time.deltaTime, 0);
        }
    }
}
