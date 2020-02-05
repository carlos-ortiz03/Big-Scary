using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public CharacterController controller;
    
    public float speed = 12f; //player speed movemnt
    public float gravity = -50f; //how long player falls
    public float jumpHeight = 3f;

    public Transform groundCheck; // check to see what the player is standing on
    public float groundDistance = 0.4f; // the sphere that would be checking^
    public LayerMask groundMask; // control on what object that the sphere should check for

    private Vector3 velocity;
    private bool isGrounded;
   
    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
            
        float x = Input.GetAxis("Horizontal"); //moving left and right
        float z = Input.GetAxis("Vertical"); //moving up and down

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        
        controller.Move(velocity * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 24f;
        }
        else
        {
            speed = 12f;
        }

    }
}
