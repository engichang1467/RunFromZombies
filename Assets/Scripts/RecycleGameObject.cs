/**
    **GameObjectUtil.cs**

    This file will set a mark for to recycle the obstacles off the screen

    ----

    *Created by Michael Chang on 2020-11-12.*

    *Copyright (c) 2020. All rights reserved.*
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRecycle{
    void Restart();
    void Shutdown();

}

public class RecycleGameObject : MonoBehaviour
{
    private List<IRecycle> recycleComponents;

    void Awake()
    {
        var components = GetComponents<MonoBehaviour>();
        recycleComponents = new List<IRecycle>();
        foreach(var component in components)
        {
            if (component is IRecycle)
            {
                recycleComponents.Add(component as IRecycle);
            }
        }

    }

    public void Restart()
    {
        gameObject.SetActive(true);

        foreach(var component in recycleComponents)
        {
            component.Restart();
        }
    }

    public void Shutdown()
    {
        gameObject.SetActive(false);

        foreach(var component in recycleComponents)
        {
            component.Shutdown();
        }
    }
}
