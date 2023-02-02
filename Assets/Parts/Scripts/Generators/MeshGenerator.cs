using UnityEngine;

public static class MeshGenerator
{
    public static Mesh CreateCylinder(float radius, float height, int LOD)
    {
        MeshData data = new MeshData(LOD * 2);

        //Create top/bottom circle faces
        for (int i = 0; i < LOD; i++)
        {
            float x = Mathf.Cos(i / 360f);
            float y = Mathf.Sin(i / 360f);

            data.vertices[i] = new Vector3(x, 0, y);
            data.vertices[LOD + i] = new Vector3(x, height, y);
        }

        return data.CreateMesh();
    }
}
