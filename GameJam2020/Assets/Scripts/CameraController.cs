using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    public Animator anima;
    public float speed;
    public float rotationSpeed;
    public Camera mainCamera;
//
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
    }

    void FixedUpdate()
    {
        Vector3 fromCameraToMe = transform.position - mainCamera.transform.position;
        fromCameraToMe.y = 0;
        fromCameraToMe.Normalize();
                                   
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = (fromCameraToMe * moveVertical + mainCamera.transform.right * moveHorizontal);

        rb.MovePosition(transform.position + Time.deltaTime * speed * movement);
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), rotationSpeed);
        }
    }
    void Update()
    {
        anima.SetBool("run",Input.GetButton("Vertical")||Input.GetButton("Horizontal")); 
        anima.SetBool("carry",Input.GetKey(KeyCode.Space));        
    }
}