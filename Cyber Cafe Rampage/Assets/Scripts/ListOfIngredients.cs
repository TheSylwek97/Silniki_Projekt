using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class ListOfIngredients : MonoBehaviour {

    public int number = 0;
    public List<string> ListOfItem = new List<string>();
    public GameObject coffee;

    [SerializeField]
    public string LevelCompleted, LevelFail;
    public GameObject oldPic, newPic, fire, steam;

    void Update ()
    {
        IsCorrect();
    }

    void Start()
    {
        oldPic.GetComponent<GameObject>();
        newPic.GetComponent<GameObject>();
        fire.GetComponent<GameObject>();
        steam.GetComponent<GameObject>();
        newPic.gameObject.SetActive(false);
        fire.gameObject.SetActive(false);
        steam.gameObject.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        string name = collider.gameObject.name;
        ListOfItem.Add(name);
        Instantiate(coffee, new Vector2(-5.54F, -1.4F), Quaternion.identity);
        number += 1;   
    }

    public void IsCorrect()
    {
        Recipe recipe = gameObject.GetComponent<Recipe>();

        if (number == recipe._number)
        {
            if (Recipe.RecipeList.SequenceEqual(ListOfItem))
            {
                Invoke("LoadLevelCompletedScene", 4.5f);
                Invoke("Animations", 2.5f);
            }
            else
                SceneManager.LoadScene(LevelFail);
        }
    }

    private void Animations()
    {
        oldPic.gameObject.SetActive(false);
        newPic.gameObject.SetActive(true);
        fire.gameObject.SetActive(true);
        steam.gameObject.SetActive(true);
    }

    private void LoadLevelCompletedScene()
    {
        SceneManager.LoadScene(LevelCompleted);
    }
}
