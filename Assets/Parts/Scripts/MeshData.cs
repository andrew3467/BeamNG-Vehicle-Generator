using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshData
{
    public Vector3[] vertices;
    public Vector2[] uv;
    private List<int> triangles;

    public MeshData(int vertexCnt)
    {
        vertices = new Vector3[vertexCnt];
        uv = new Vector2[vertexCnt];
        triangles = new List<int>();
    }

    public void AddTriangle(params int[] indices)
    {
        triangles.AddRange(indices);
    }

    public Mesh CreateMesh()
    {
        Mesh m = new Mesh()
        {
            vertices = vertices,
            uv = uv,
            triangles = triangles.ToArray()
        };
        m.RecalculateBounds();
        m.RecalculateNormals();
        m.RecalculateTangents();

        return m;
    }
}
