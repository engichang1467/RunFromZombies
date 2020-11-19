/**
    **PlayerAnimationManager.cs**

    This file will help switching the running animation (running or not running) of the player.
        
        (the player is standing on the ground) => (runinng)
        (the player is standing on the obstacle) => (not running)

    ----

    *Created by Michael Chang on 2020-11-12.*

    *Copyright (c) 2020. All rights reserved.*
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    private Animator animator;
    private InputState inputState;

    void Awake()
    {
        animator = GetComponent<Animator>();
        inputState = GetComponent<InputState>();
    }

    // Update is called once per frame
    void Update()
    {
        var running = true;

        if (inputState.absVelX > 0 && inputState.absVelY < inputState.standingThreshold)
            running = false;

        animator.SetBool("Running", running);
        
    }
}
