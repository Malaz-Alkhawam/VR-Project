using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MyGameObject : MonoBehaviour
{
    private UnityEngine.GameObject obj;
    public float mass = 20;
    public UnityEngine.Vector3 veclocity; // vector
    public UnityEngine.Vector3 acceleration; // vector
    public MyGameObject(UnityEngine.GameObject objec)
    {
        obj = objec;
    }

    public void UpdateValues(UnityEngine.Vector3 force, float dt)
    {
        acceleration += force / mass;
        veclocity += acceleration * dt;
        obj.transform.position += veclocity * dt;
    }

}
