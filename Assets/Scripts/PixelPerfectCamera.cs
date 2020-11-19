/** 
    **PixelPerfectCamera.cs**

    This will make sure that the camera will automatically resize the screen to fit everything perfectly

    ---- 

    *Created by Michael Chang on 2020-11-11.*

    *Copyright (c) 2020. All rights reserved.*
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour
{
    public static float pixelsToUnits = 1f;
    public static float scale = 1f;

    public Vector2 nativeResolution = new Vector2(240, 160);

    void Awake()
    {
        var camera = GetComponent<Camera>();

        if (camera.orthographic) {
            scale = Screen.height/nativeResolution.y;
            pixelsToUnits *= scale;
            camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
        }
        
    }

}
