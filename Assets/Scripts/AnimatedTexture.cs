/**
    **AnimatedTexture.cs**

    This file will help animate repeat background texture
    Make it look like player is moving in one direction

    ----

    *Created by Michael Chang on 2020-11-11.*

    *Copyright (c) 2020. All rights reserved.*
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedTexture : MonoBehaviour
{
    public Vector2 speed = Vector2.zero;
    
    private Vector2 offset = Vector2.zero;
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;

        offset = material.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset += speed * Time.deltaTime;

        material.SetTextureOffset("_MainTex", offset);
    }
}
