using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour

{
    public CharacterController controller;
    private Animator _animator;

    void start()
    {
        controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }
    public Animator animate;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) ;
        {
            _animator.SetInteger("Condition", 1);
            Debug.Log("It works");
        }
    }
}
