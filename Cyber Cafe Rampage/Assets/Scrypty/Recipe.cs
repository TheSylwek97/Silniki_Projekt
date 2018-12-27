using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour {

    public GameObject level;
    public List<string> RecipeList = new List<string>();
    public int _number = 0;
    public void Start()
    {
        string _tag = level.tag;

        if (_tag == "probny")
        {
            RecipeList.Add("Mleko");
            _number = 1;
            gameObject.SendMessage("ListOfIngredients", RecipeList);
        }

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

    public void Send(List<string> RecipeList)
    {
        gameObject.SendMessage("ListOfIngredients", RecipeList);
    }
}
