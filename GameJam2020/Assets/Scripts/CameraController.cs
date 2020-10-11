using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public GameObject mainCamera;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    void FixedUpdate()
    {
        Vector3 fromCameraToMe = transform.position - mainCamera.transform.position;
        fromCameraToMe.y = 0; // First, zero out any vertical component, so the movement plane is always horizontal.
        fromCameraToMe.Normalize(); // Then, normalize the vector to length 1 so that we don't affect the player more strongly when the camera is at different distances.
                                   
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // We can cheat a bit here - we had to flatten out the 'forward' vector from the camera to the player, but the camera is always horizontal left-right, so we can just use
        // its 'transform.right' vector to determine the direction to move the ball. Add the horizontal and vertical vectors to determine ground-plane movement.
        Vector3 movement = (fromCameraToMe * moveVertical + mainCamera.transform.right * moveHorizontal);

        //rb.velocity = movement * Time.deltaTime * speed;
        rb.MovePosition(transform.position + Time.deltaTime * speed * movement);
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), rotationSpeed);
        }
    }
}