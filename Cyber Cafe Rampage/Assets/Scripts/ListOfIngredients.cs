using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class ListOfIngredients : MonoBehaviour {

    public int number = 0;
    public List<string> ListOfItem = new List<string>();
    public GameObject coffee;
    
	void Update ()
    {
        IsCorrect();
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        string name = collider.gameObject.name;
        ListOfItem.Add(name);
        Instantiate(coffee, new Vector2(0.67F, -2.194F), Quaternion.identity);
        number += 1;   
    }

    public void IsCorrect( )
    {
        Recipe recipe = gameObject.GetComponent<Recipe>();
        
        if (number == recipe._number)
        {
            if (recipe.RecipeList.SequenceEqual(ListOfItem))
            {
                SceneManager.LoadScene("Level Completed");
            }
            else
            {
                Debug.Log("Lipa");
            }
        }
        
    }
}
