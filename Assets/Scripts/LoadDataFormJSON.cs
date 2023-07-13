using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class LoadDataFormJSON : MonoBehaviour
{
    public TextAsset dbAsset;
    public GameObject charceterPrefab;

    public void LoadDtFormJSON(string path)
    {
        TextAsset data = Resources.Load(path) as TextAsset;

        var jsonData = JSON.Parse(data.text);

        Debug.Log(jsonData.Count);

        int rnd = Random.Range(0, jsonData.Count);

        GameObject charceter = Instantiate(charceterPrefab);
        string nameInJson = jsonData[rnd]["Name"].ToString();
        charceter.name = nameInJson.Replace("\"", "");
        charceter.GetComponent<Status>().hp = float.Parse(jsonData[rnd]["HP"].ToString());
        charceter.GetComponent<Status>().mp = float.Parse(jsonData[rnd]["MP"].ToString());
        charceter.GetComponent<Status>().ad = float.Parse(jsonData[rnd]["AD"].ToString());
        charceter.GetComponent<Status>().asp = float.Parse(jsonData[rnd]["AS"].ToString());
    }
}
