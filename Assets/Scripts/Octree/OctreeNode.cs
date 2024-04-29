using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctreeNode
{
    Bounds nodeBounds;
    OctreeNode[] child;

    GameObject data;
    float minSize;
    public OctreeNode(Bounds b, float mineNodeSize)
    {
        nodeBounds = b;
        minSize = mineNodeSize;
    }

    public void Draw()
    {
        Gizmos.color = new Color(0, 1, 0);
        Gizmos.DrawWireCube(nodeBounds.center, nodeBounds.size);
    }

}
