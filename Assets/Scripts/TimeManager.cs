/**
    **TimeManager.cs**

    This file will help pause the game stop by manipulating time and set the time scale to zero.
        - use for stopping the game after player die
        - use for restarting the level
    
    ----

    *Created by Michael Chang on 2020-11-13.*

    *Copyright (c) 2020. All rights reserved.*
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public void ManipulateTime(float newTime, float duration)
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 0.1f;
        }

        StartCoroutine(FadeTo(newTime, duration));
    }

    IEnumerator FadeTo(float value, float time)
    {
        for (float t = 0f; t < 1; t += Time.deltaTime / time)
        {
            Time.timeScale = Mathf.Lerp(Time.timeScale, value, t);

            if (Mathf.Abs(value - Time.timeScale) < .01f)
            {
                Time.timeScale = value;
                yield break; // do not use yield return since it'll pause the game after restart
            }

            yield return null;
        }
    }
}
