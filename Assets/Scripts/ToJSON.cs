using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player
{
    public string playerName;
    public int playerLv;
    public int playerHp;
    public int playerMp;
    public int playerDef;
}

public class ToJSON : MonoBehaviour
{
    private void Start()
    {
        Player player = new Player();

        player.playerName = "Player01";
        player.playerLv = 1;
        player.playerHp = 100;
        player.playerMp = 25;
        player.playerDef = 5;

        //Debug.Log(player.playerName);
        //Debug.Log(player.playerLv);

        string jsonData = JsonUtility.ToJson(player);
        Debug.Log(jsonData);

        PlayerPrefs.SetString("PlayerData", jsonData);
    }   
}

