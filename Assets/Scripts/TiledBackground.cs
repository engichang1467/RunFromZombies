/**
    **TileBackground.cs**

    This file will help scale our background texture to fill up the view

    ----

    *Created by Michael Chang on 2020-11-11.*

    *Copyright (c) 2020. All rights reserved.*
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiledBackground : MonoBehaviour
{
    public int textureSize = 32;
    public bool scaleHorizontally = true;
    public bool scaleVertically = true;

    // Start is called before the first frame update
    void Start()
    {
        var newWidth = !scaleHorizontally ? 1 : Mathf.Ceil(Screen.width / (textureSize * PixelPerfectCamera.scale));
        var newHeight = !scaleVertically ? 1 : Mathf.Ceil(Screen.height / (textureSize * PixelPerfectCamera.scale));

        // change the scale of our background
        transform.localScale = new Vector3(newWidth * textureSize, newHeight * textureSize, 1);

        // Tell the material that we've created that it has a new scale
        GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth, newHeight, 1);

    }

}
