using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wheel : Part
{
    public Vector3[] vertices;
    
    public Wheel() : base(PartType.Wheel)
    {
        obj = new GameObject("Wheel", typeof(MeshFilter), typeof(MeshRenderer));   
        GenerateModel();
    }

    public override void GenerateModel()
    {
        Mesh mesh = MeshGenerator.CreateCylinder(1f, 10f, 4);
        MeshFilter filter = obj.GetComponent<MeshFilter>();
        filter.mesh = mesh;

        vertices = mesh.vertices;
    }
}
