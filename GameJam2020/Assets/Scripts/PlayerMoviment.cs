using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
<<<<<<< HEAD
    public Animator animator; 
        
    void Update()
    {
        animator.SetFloat("vertical",Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal",Input.GetAxis("Horizontal"));
=======

    public float speed;

    private float _xAxis;
    private float _zAxis;
    private Rigidbody _rb;
    private RaycastHit _hit;
    private Vector3 _groundLocation;
    private bool isCapsLockPressedDown;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();   
    }

    void Update()
    {
        _xAxis = Input.GetAxis("Horizontal");
        _zAxis = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(transform.position + Time.deltaTime * speed * transform.TransformDirection(_xAxis, 0f, _zAxis));
>>>>>>> develop
    }
}