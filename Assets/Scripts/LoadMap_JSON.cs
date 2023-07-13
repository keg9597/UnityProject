using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class LoadMap_JSON : MonoBehaviour
{
    public TextAsset dbAsset;

    public void LoadLVFormJSON(string path)
    {
       TextAsset data = Resources.Load(path) as TextAsset;

        var jsonData = JSON.Parse(data.text);

        Debug.Log(jsonData.Count);
        for (int i = 0; i < jsonData.Count; i++)
        {
            Debug.Log(jsonData[i]["StageName"]);//문자열 주의!!
        }
    }
}
