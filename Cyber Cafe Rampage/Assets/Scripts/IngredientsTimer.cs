using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class IngredientsTimer : MonoBehaviour {



    [SerializeField]
    public string levelName;
    public float setTime;
    public float runTime = 0f;

    public void Update()
    {
        runTime += Time.deltaTime;
        if (runTime>= setTime)
        {
             SceneManager.LoadScene(levelName);
        }

    }
}
