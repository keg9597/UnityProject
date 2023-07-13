using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLevelFormCSV : MonoBehaviour
{
    public List<Dictionary<string, object>> data;
    public Text dataTxt;
    
    public void LoadLVFormCSV(string path)
    {
        data = CSVReader.Read(path);
        dataTxt.text = "";
        for (int i = 0; i < data.Count; i++)
        {
            dataTxt.text += data[i]["StageNo"] + "\n";
            Debug.Log("EnemyCnt" + data[i]["EnemyCnt"]);
            Debug.Log("BossCnt" + data[i]["BossCnt"]);
            Debug.Log("ClearScore" + data[i]["ClearScore"]);
            Debug.Log("ClearGold" + data[i]["ClearGold"]);
            Debug.Log("LimitTime" + data[i]["LimitTime"]);            
        }
    }
}
