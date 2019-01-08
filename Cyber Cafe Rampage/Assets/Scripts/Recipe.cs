using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour {

    public GameObject level;
    static public List<string> RecipeList = new List<string>();
    public int _number = 0;
    public void Start()
    {
        //level = GameObject.Find("GameMaster");
       // string _tag = level.tag;
       /*
        if (level.tag == "probny")
        {
            RecipeList.Add("Mleko");
            _number = 1;
            //gameObject.SendMessage("ListOfIngredients", RecipeList);
        }
        */
        if (level.tag == "Level01")
        {
            RecipeList.Add("Espresso(Clone)");
            RecipeList.Add("Mleko(Clone)");
            RecipeList.Add("CynamonMielony(Clone)");
            RecipeList.Add("Miod(Clone)");
            _number = 4;
        }
        if (tag == "Level02")
        {
            RecipeList.Add("GorzkieKakao(Clone)");
            RecipeList.Add("CukierBialy(Clone)");
            RecipeList.Add("MieloneChili(Clone)");
            RecipeList.Add("CynamonMielony(Clone)");
            _number = 4;
        }
        if (tag == "Level03")
        {
            RecipeList.Add("Mleko(Clone)");
            RecipeList.Add("BialaCzekolada(Clone)");
            RecipeList.Add("Amaretto(Clone)");
            RecipeList.Add("EkstaktWaniliowy(Clone)");
            RecipeList.Add("Espresso(Clone)");
            _number = 5;
        }
        if (tag == "Level04")
        {
            RecipeList.Add("Mleko(Clone)");
            RecipeList.Add("Espresso(Clone)");
            RecipeList.Add("SyropKlonowy(Clone)");
            RecipeList.Add("PrzyprawaPiernikowa(Clone)");
            RecipeList.Add("BitaSmietana(Clone)");
            RecipeList.Add("Pierniczki(Clone)");
            _number = 6;
        }
        if (tag == "Level05")
        {
            RecipeList.Add("CynamonMielony(Clone)");
            RecipeList.Add("MielonaGałkaMuszkatołowa(Clone)");
            RecipeList.Add("MieloneImbir(Clone)");
            RecipeList.Add("MieloneGodzdziki(Clone)");
            RecipeList.Add("Mleko(Clone)");
            RecipeList.Add("BitaSmietana(Clone)");
            RecipeList.Add("PureeDyniowe(Clone)");
            RecipeList.Add("PrzyprawaDoKawy(Clone)");
            RecipeList.Add("EkstaktWaniliowy(Clone)");
            RecipeList.Add("Espresso(Clone)");
            _number = 10;
        }
    }
    

    /*public void Send(List<string> RecipeList)
    {
        gameObject.SendMessage("ListOfIngredients", RecipeList);
    }*/
}
