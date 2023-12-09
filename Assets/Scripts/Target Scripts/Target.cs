using System;
using UnityEngine;
[Serializable]
public class Target
{
    // Name of the target
    public string Name;

    // Floor number where the target is located
    public int floorNumber;

    // Position of the target in 3D space
    public Vector3 Position;

    // Rotation of the target in 3D space
    public Vector3 Rotation;
}

