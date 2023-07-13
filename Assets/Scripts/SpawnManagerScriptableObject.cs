using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data",
    menuName = "ScriptableObject/SpawnManagerScriptableObject",
    order = 1)]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public string prefabName;

    public int numberOFPrefabsToCreate;
    public Vector3[] spawnPoints;
}
