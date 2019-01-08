using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {


    [SerializeField]
    public string LevelCompleted;
    public static string LevelFail;

    
    public static void LoadWin()
    {
        //SceneManager.LoadScene(LevelCompleted);
    }

    public void LoadLose()
    {

    }
}
