using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Part
{
    public enum PartType
    {
        Empty = 0,
        Wheel = 1
    }

    public Part(PartType type = PartType.Empty)
    {
        this.type = type;
    }
    
    public PartType type;
    public GameObject obj;


    public abstract void GenerateModel();
}