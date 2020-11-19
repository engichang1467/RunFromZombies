/**
    **InstantVelocity.cs**

    This file will help make our obsticles to move across the screen

    ----

    *Created by Michael Chang on 2020-11-11.*

    *Copyright (c) 2020. All rights reserved.*
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantVelocity : MonoBehaviour
{
    public Vector2 velocity = Vector2.zero;

    private Rigidbody2D body2D;

    void Awake() {
        body2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        body2D.velocity = velocity;
    }

}
