using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    public GameObject prefab;

    public SpawnManagerScriptableObject spawnManagerValue;

    //int instanceNumber = 1;

    void Start()
    {
        SpawnEntities();
    }

    void SpawnEntities()
    {
        //int curSpawnPointIDX = 0;
        for (int i = 0; i < spawnManagerValue.numberOFPrefabsToCreate; i++)
        {
            GameObject character = Instantiate(prefab,
                spawnManagerValue.spawnPoints[i], Quaternion.identity);
        }
    }
}
