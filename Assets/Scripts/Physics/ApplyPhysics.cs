using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyPhysics : MonoBehaviour
{
    public List<GameObject> worldObjects;
    public float gravity = -9.8f;
    public Vector3 force;
    private Physics py;
    void Start()
    {
        py = new Physics(worldObjects);

    }

    // Update is called once per frame
    void Update()
    {
        py.ApplyGravity(gravity);

        py.ApplyForce(force);
    }
}
