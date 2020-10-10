using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public Animator animator; 

    public float speed;

    private float _xAxis;
    private float _zAxis;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();   
    }

    void Update()
    {
    
        animator.SetFloat("vertical",Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal",Input.GetAxis("Horizontal"));

        _xAxis = Input.GetAxis("Horizontal");
        _zAxis = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(transform.position + Time.deltaTime * speed * transform.TransformDirection(_xAxis, 0f, _zAxis));
    }
}