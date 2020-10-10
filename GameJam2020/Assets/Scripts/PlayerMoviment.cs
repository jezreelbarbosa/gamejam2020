using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{

    float Speed;
    void Start()
    {
        Speed = 5;
    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * Speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * Speed);
    }
}