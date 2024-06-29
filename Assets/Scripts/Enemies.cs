using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemies
{
    public virtual void spawnMessage()
    {
        Debug.Log("An enemy has spawned");
    }
}
