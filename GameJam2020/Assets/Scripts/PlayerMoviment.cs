using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public Animator animator; 
        
    void Update()
    {
        animator.SetFloat("vertical",Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal",Input.GetAxis("Horizontal"));
    }
}