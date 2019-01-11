using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetttings : MonoBehaviour {

	public static void SaveData(Player player)
    {
        PlayerPrefs.SetInt("level", PlayerData.whichLvl);
    }

    public static int LoadData()
    {
        int level;// = PlayerData.whichLvl;
        level = PlayerPrefs.GetInt("level");

        return level;
    }
}
