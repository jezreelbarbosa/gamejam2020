using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{    
    float mH = Input.GetAxis("Horizontal");
    float mV = Input.GetAxis("Vertical");
    public float speed = 5f;
    public Animator anima;
    Rigidbody rb;

 
    void Start () {
    rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate () {
        rb.velocity = new Vector3 (mH * speed* Time.deltaTime, rb.velocity.y, mV * speed* Time.deltaTime) ;
    }
    //void Update()
    //{
    //    transform.position = new Vector3(h, 0, v) * speed * Time.deltaTime;
    //    anima.SetBool("run",Input.GetButton("Vertical")||Input.GetButton("Horizontal")); 
    //    anima.SetBool("carry",Input.GetKey(KeyCode.Space));        
    //}
}