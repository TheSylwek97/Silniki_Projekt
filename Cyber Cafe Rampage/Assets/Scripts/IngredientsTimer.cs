using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class IngredientsTimer : MonoBehaviour {

    [SerializeField]
    public string levelName;
    public float setTime;
    public float runTimeDontChange = 0f;

    public void Update()
    {
        runTimeDontChange += Time.deltaTime;
        if (runTimeDontChange >= setTime)
        {
             SceneManager.LoadScene(levelName);
        }

    }
}
