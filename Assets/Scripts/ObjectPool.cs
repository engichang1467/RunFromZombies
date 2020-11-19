/**
    **ObjectPool.cs**

    This file will look through it's list of inactive objects, and return them to the screen. 
    Or else it will create a new one for you

    Object pool is a class  that manage instances that it creates
        - Also manage whether the objects are inactive or active

    Self reminder:
        Instance - concrete occurence of any object
            Ex. An object is an instance of a class
                - think of class as a blue print of a house
                - think of object as a house

    ----

    *Created by Michael Chang on 2020-11-12.*

    *Copyright (c) 2020. All rights reserved.*
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public RecycleGameObject prefab;

    private List<RecycleGameObject> poolInstances = new List<RecycleGameObject>();

    private RecycleGameObject CreateInstance(Vector3 pos)
    {
        var clone = GameObject.Instantiate(prefab);
        clone.transform.position = pos;
        clone.transform.parent = transform;

        poolInstances.Add(clone);

        return clone;
    }

    public RecycleGameObject NextObject(Vector3 pos)
    {
        RecycleGameObject instance = null;

        foreach(var go in poolInstances) 
        {
            if (go.gameObject.activeSelf != true)
            {
                instance = go;
                instance.transform.position = pos;
            }
        }

        if (instance == null)
            instance = CreateInstance(pos);
            
        instance.Restart();

        return instance;
    }
}
