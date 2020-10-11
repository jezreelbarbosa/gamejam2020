using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{    
    public Animator anima;
    void Start()
    {
    
    }
    void Update()
    {
        anima.SetBool("run",Input.GetButton("Vertical")||Input.GetButton("Horizontal"));
        Debug.Log(Input.GetButton("Vertical"));
        anima.SetBool("carry",Input.GetKey(KeyCode.Space));

    }
}