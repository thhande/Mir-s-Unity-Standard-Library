using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnable : MMono
{
    public void SetSpawnInfo(Vector2 position, Quaternion rotation)
    {
        transform.position = position;
        transform.rotation = rotation;
    }

    public void SetPosition(Vector2 position)
    {
        transform.position = position;
    }
}
