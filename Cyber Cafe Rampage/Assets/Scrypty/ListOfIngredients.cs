using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ListOfIngredients : MonoBehaviour {


    public List<string> RecipeList = new List<string>();
    public List<string> ListOfItem = new List<string>();
    [SerializeField]
    public GameObject level;
    public int number = 0;
    public int _number = 0;
    // Use this for initialization
    void Start () {
        string _tag = level.tag;

        if (_tag == "Level01")
        {
            RecipeList.Add("Milk");
            RecipeList.Add("Sugar");
            _number = 2;
            
        }
        if (_tag == "Level02")
        {
            RecipeList.Add("Sugar");
        }
    }
	
	// Update is called once per frame
	void Update () {
        IsCorrest();
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        string name = collider.gameObject.name;
        ListOfItem.Add(name);
        number += 1;

    }

    public void IsCorrest()
    {
        if (number == _number)
        {

            if (RecipeList.SequenceEqual(ListOfItem))
            {
                Debug.Log("JEJ!");
            }
        }

        else
        {
            Debug.Log("O nie!");
        }
    }
}
