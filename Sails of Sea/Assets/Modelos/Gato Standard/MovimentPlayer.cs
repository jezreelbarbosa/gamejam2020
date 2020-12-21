using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentPlayer : MonoBehaviour
{
    
    Animator animator;
    public CharacterController controller;

    public Transform cam;

    public float jumpSpeed = 0.2f;
    public float gravity = 0.5f;
    public float speed = 10f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    
    Vector3 moveVector;

    void Start()
    {
       animator = GetComponent<Animator>();
    }    
    void Update()
    {        
        
     
      moveVector = new Vector3 (moveVector.x,moveVector.y,moveVector.z); 
      if(PlayerJumped){
          moveVector.y = jumpSpeed;
      }else if(controller.isGrounded){
          moveVector.y = 0f;
      }else{
          moveVector.y -= gravity * Time.deltaTime; 
      }
      controller.Move(moveVector);      

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal,0f,vertical).normalized;
        Vector3 inputDirection = new Vector3(horizontal,0f,vertical);
        Vector3 transformDirection = transform.TransformDirection(inputDirection);
        if (direction.magnitude >= 0.1f){
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime );
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
           

            Vector3 movDir = Quaternion.Euler(0f, targetAngle,0f) * Vector3.forward;
            controller.Move(movDir.normalized *speed * Time.deltaTime );
        }
    }
    private bool PlayerJumped => controller.isGrounded && Input.GetKey(KeyCode.Space);
    
}
