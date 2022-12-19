using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody _rigidbody;
    [SerializeField] PlayerOnFootInput PlayerFootInput;
    [SerializeField] PlayerInput playerInput;
    Vector3 playerMoveInput;
    //Vector3 playerLookInput;



 



    [SerializeField] float speed = 30.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
     
        
    }


    private void FixedUpdate()
    {
        
        PlayerMove();
        PlayerLook();
        _rigidbody.AddForce(playerMoveInput,ForceMode.Force);


      
    }

   

    private void PlayerMove()
    {
       
        playerMoveInput = new Vector3(PlayerFootInput.MoveInput.x * _rigidbody.mass * speed, 0.0f, PlayerFootInput.MoveInput.y * _rigidbody.mass * speed);
        
    }

    private void PlayerLook()
    {
        Vector3 playerLookPosition = PlayerFootInput.getMousePosition() + Vector3.up * transform.position.y;


           transform.LookAt(playerLookPosition);
    }


    
}
