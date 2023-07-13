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

        Debug.Log($"JsonUtility플레이어 이름 : {player.playerName}");
        Debug.Log($"JsonUtility플레이어 레벨 : {player.playerLv}");
        Debug.Log($"JsonUtility플레이어 체력 : {player.playerHp}");
        Debug.Log($"JsonUtility플레이어 마력 : {player.playerMp}");
        Debug.Log($"JsonUtility플레이어 방어력 : {player.playerDef}");

        var jsonData = JSON.Parse(fromJsonData);
        //Debug.Log(jsonData);
        Debug.Log($"SimpleJSON플레이어 이름 : {jsonData["playerName"]}");
        Debug.Log($"SimpleJSON플레이어 레벨 : {jsonData["playerLv"]}");
        Debug.Log($"SimpleJSON플레이어 체력 : {jsonData["playerHp"]}");
        Debug.Log($"SimpleJSON플레이어 마력 : {jsonData["playerMp"]}");
        Debug.Log($"SimpleJSON플레이어 방어력 : {jsonData["playerDef"]}");
    }
}
