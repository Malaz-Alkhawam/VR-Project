using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOctree : MonoBehaviour
{

    public GameObject[] worldObjects;
    public int nodeMinSize = 1;
    Octree otree;
    // Start is called before the first frame update
    void Start()
    {

        otree = new Octree(worldObjects, nodeMinSize);
    }
    // void Update()
    // {

    // }

    void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            // Debug.Log("asd");
            otree.rootNode.Draw();

        }
    }
}
