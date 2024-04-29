using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Physics
{
    public List<MyGameObject> worldObjects = new();

    public Physics(List<GameObject> objs)
    {
        foreach (GameObject i in objs)
        {
            worldObjects.Add(new MyGameObject(i));
        }

    }
    public void ApplyGravity(float gravity)
    {

        foreach (MyGameObject i in worldObjects)
        {
            // ApplyForce(new Vector3(0, -i.mass * gravity, 0));
            ApplyForce(new Vector3(0, -0.0098f, 0));
        }


    }

    public void ApplyForce(UnityEngine.Vector3 force)
    {

        foreach (MyGameObject i in worldObjects)
        {
            i.UpdateValues(force, 0.01f);
        }

    }




}
