using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour {

    public GameObject level;
    public List<string> RecipeList = new List<string>();
    public int _number = 0;
    public void Start()
    {
        //level = GameObject.Find("GameMaster");
       // string _tag = level.tag;

        if (level.tag == "probny")
        {
            RecipeList.Add("Mleko");
            _number = 1;
            //gameObject.SendMessage("ListOfIngredients", RecipeList);
        }

        if (level.tag == "Level01")
        {
            RecipeList.Add("Miod");
            RecipeList.Add("CynamonMielony");
            RecipeList.Add("Mleko");
            RecipeList.Add("Espresso");
            _number = 4;
        }
        if (tag == "Level02")
        {
            RecipeList.Add("GorzkieKakao");
            RecipeList.Add("CukierBialy");
            RecipeList.Add("MieloneChili");
            RecipeList.Add("CynamonMielony");
            _number = 4;
        }
        if (tag == "Level03")
        {
            RecipeList.Add("Mleko");
            RecipeList.Add("BialaCzekolada");
            RecipeList.Add("Amaretto");
            RecipeList.Add("EkstaktWaniliowy");
            RecipeList.Add("Espresso");
            RecipeList.Add("EspressoPodwojne");
            _number = 6;
        }
        if (tag == "Level04")
        {
            RecipeList.Add("Mleko");
            RecipeList.Add("Espresso");
            RecipeList.Add("SyropKlonowy");
            RecipeList.Add("PrzyprawaPiernikowa");
            RecipeList.Add("BitaSmietana");
            RecipeList.Add("Pierniczki");
            _number = 6;
        }
        if (tag == "Level05")
        {
            RecipeList.Add("Mleko");
            RecipeList.Add("PureeDyniowe");
            RecipeList.Add("CukierBialy");
            RecipeList.Add("CynamonMielony");
            RecipeList.Add("MielonaGałkaMuszkatołowa");
            RecipeList.Add("MieloneImbir");
            RecipeList.Add("Gozdziki");
            RecipeList.Add("Espresso");
            RecipeList.Add("EkstaktWaniliowy");
            RecipeList.Add("BitaSmietana");
            _number = 10;
        }
    }

    /*public void Send(List<string> RecipeList)
    {
        gameObject.SendMessage("ListOfIngredients", RecipeList);
    }*/
}
