using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    
    
    public float speed = 6f; //player speed movemnt
    public float gravity = -50f; //how long player falls
    public float jumpHeight = 3f;

    public Transform groundCheck; // check to see what the player is standing on
    public float groundDistance = 0.4f; // the sphere that would be checking^
    public LayerMask groundMask; // control on what object that the sphere should check for

    private Vector3 velocity;
    private bool isGrounded;
    
    public CharacterController controller;
    private Animator _animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        
        velocity.y += gravity * Time.deltaTime;
        
        
        float x = Input.GetAxis("Horizontal"); //moving left and right
        float z = Input.GetAxis("Vertical"); //moving up and down

        Vector3 move = transform.right * x + transform.forward * z;
        
        
        controller.Move(move * speed * Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            _animator.SetInteger("Condition",1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetInteger("Condition",0);
        }


        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 12f;
            
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 6f;
        }
    }
}