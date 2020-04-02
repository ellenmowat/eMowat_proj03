﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    //gives us access to the object controller of type CharacterController2D

    public float runSpeed = 25f;

    float horizontalMove = 0f;
    bool jumpFlag = false;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (jumpFlag)
        {
            jumpFlag = false;
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        if(jump)
        {
            jumpFlag = true;
        }
    }

}