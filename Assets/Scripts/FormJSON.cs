using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class FormJSON : MonoBehaviour
{
    private void Start()
    {
        string fromJsonData = PlayerPrefs.GetString("PlayerData");
        
        Debug.Log(fromJsonData);

        Player player = JsonUtility.FromJson<Player>(fromJsonData);

        Debug.Log($"JsonUtility�÷��̾� �̸� : {player.playerName}");
        Debug.Log($"JsonUtility�÷��̾� ���� : {player.playerLv}");
        Debug.Log($"JsonUtility�÷��̾� ü�� : {player.playerHp}");
        Debug.Log($"JsonUtility�÷��̾� ���� : {player.playerMp}");
        Debug.Log($"JsonUtility�÷��̾� ���� : {player.playerDef}");

        var jsonData = JSON.Parse(fromJsonData);
        //Debug.Log(jsonData);
        Debug.Log($"SimpleJSON�÷��̾� �̸� : {jsonData["playerName"]}");
        Debug.Log($"SimpleJSON�÷��̾� ���� : {jsonData["playerLv"]}");
        Debug.Log($"SimpleJSON�÷��̾� ü�� : {jsonData["playerHp"]}");
        Debug.Log($"SimpleJSON�÷��̾� ���� : {jsonData["playerMp"]}");
        Debug.Log($"SimpleJSON�÷��̾� ���� : {jsonData["playerDef"]}");
    }
}
