using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetttings : MonoBehaviour {

	public static void SaveData(Player player)
    {
        PlayerPrefs.SetInt("level", PlayerData.whichLvl);
    }/*
    public static PlayerData PlayerData()
    {
        int level = PlayerPrefs.GetInt("level");
        PlayerData playerData = new PlayerData()
        {
            Level = level;
        }
        
        return PlayerData;

    }*/

    public static int LoadData()
    {
        int level = PlayerPrefs.GetInt("level");

        return level;
    }
}
