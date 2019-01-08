using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour {

    //PlayerPrefs.SetInt("Player Score", 10);
    //[SerializeField]
    public static int levelCompleted=0;

    public void Start()
    {
        ReadLevel();
        Debug.Log(levelCompleted);
        levelCompleted++;
        ReadLevel();
        Debug.Log(levelCompleted);
    }

    public static void SetLevel()
    {
        PlayerPrefs.SetInt("WhichLevel", levelCompleted);
        PlayerPrefs.Save();
    }

    public static void ReadLevel()
    {
        levelCompleted = PlayerPrefs.GetInt("levelCompleted");
    }

    public static void CheckKey()
    {
        PlayerPrefs.HasKey("levelCompleted");
    }

    public static void ResetLevel()
    {
        PlayerPrefs.DeleteAll();
    }
        
}
