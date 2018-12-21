﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ListOfIngredients : MonoBehaviour {

    public int number = 0;
    public int _number = 0;
    public List<string> RecipeList = new List<string>();
    public List<string> ListOfItem = new List<string>();
    [SerializeField]
    public GameObject level;
    public GameObject coffee;
    
    
    void Start () {
        string _tag = level.tag;

        if (_tag == "Level01")
        {
            RecipeList.Add("Honey");
            RecipeList.Add("Cinnamon");
            RecipeList.Add("Milk");
            RecipeList.Add("Espresso");
            _number = 4;
            
        }
        if (_tag == "Level02")
        {
            RecipeList.Add("Kakao");
            RecipeList.Add("Sugar");
            RecipeList.Add("Chili");
            RecipeList.Add("Cinnamon");
            _number = 4;

        }
        if (_tag == "Level03")
        {
            RecipeList.Add("Milk");
            RecipeList.Add("White Chocolate");
            RecipeList.Add("Amaretto");
            RecipeList.Add("Vanilla");
            RecipeList.Add("Espresso");
            _number = 5;
        }
        if (_tag == "Level04")
        {
            RecipeList.Add("Milk");
            RecipeList.Add("Espresso");
            RecipeList.Add("Maple syrup");
            RecipeList.Add("Gingerbread spice");
            RecipeList.Add("Whipped cream");
            RecipeList.Add("Gingerbread");
            _number = 6;

        }
        if (_tag == "Level05")
        {
            RecipeList.Add("Milk");
            RecipeList.Add("Pumpkin puree");
            RecipeList.Add("Sugar");
            RecipeList.Add("Cinnamon");
            RecipeList.Add("Nutmeg");
            RecipeList.Add("Ginger");
            RecipeList.Add("Carnation");
            RecipeList.Add("Espresso");
            RecipeList.Add("Vanilla");
            RecipeList.Add("Whipped cream");
            _number = 10;

        }
       
    }

	void Update () {
        IsCorrect();
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        string name = collider.gameObject.name;
        ListOfItem.Add(name);
        Instantiate(coffee, new Vector2(0.67F, -2.194F), Quaternion.identity);
        number += 1;

    }

    public void IsCorrect()
    {
        if (number == _number)
        {

            if (RecipeList.SequenceEqual(ListOfItem))
            {
                Debug.Log("JEJ!");
            }
            else
            {
                Debug.Log("Lipa");
            }
        }
        
    }
}