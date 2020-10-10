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
        anima.SetFloat("Vertical",Input.GetAxis("vertical"));
        anima.SetFloat("Horizontal",Input.GetAxis("Horizontal"));
    }
}