/**
    **InputState.cs**

    This file will help change the movement/motion of a player,  
    and will determine what the actual physical state of the player is.

    ----

    *Created by Michael Chang on 2020-11-12.*

    *Copyright (c) 2020. All rights reserved.*
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputState : MonoBehaviour
{
    public bool actionButton;
    public float absVelX = 0f;
    public float absVelY = 0f;
    public bool standing;
    public float standingThreshold = 1;

    private Rigidbody2D body2d;

    void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        actionButton = Input.anyKeyDown;
    }

    void FixedUpdate()
    {
        absVelX = System.Math.Abs(body2d.velocity.x);
        absVelY = System.Math.Abs(body2d.velocity.y);

        standing = absVelY <= standingThreshold;
    }
}
