using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelGenerator : MonoBehaviour
{
    public Wheel w;

    private void Start()
    {
        Generate();
    }

    void Generate()
    {
        w = new Wheel();
        w.obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }


    private void OnDrawGizmos()
    {
        if(w == null) return;
        
        Gizmos.color = Color.red;

        for (int i = 0; i < w.vertices.Length; i++)
        {
            Gizmos.DrawSphere(w.vertices[i], 0.125f);
        }
    }
}
