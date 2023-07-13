using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadDataFormCSV : MonoBehaviour
{
    public List<Dictionary<string, object>> data;
    public Text dataTxt;
    public GameObject charceterPrefab;

    public void LoadDtFormCSV(string path)
    {
        data = CSVReader.Read(path);
        dataTxt.text = "";

        int rnd = Random.Range(0, data.Count);

        GameObject charceter = Instantiate(charceterPrefab);
        charceter.name = data[rnd]["Name"].ToString();
        charceter.GetComponent<Status>().hp = float.Parse(data[rnd]["HP"].ToString());
        charceter.GetComponent<Status>().mp = float.Parse(data[rnd]["MP"].ToString());
        charceter.GetComponent<Status>().ad = float.Parse(data[rnd]["AD"].ToString());
        charceter.GetComponent<Status>().asp = float.Parse(data[rnd]["AS"].ToString());
    }
}
