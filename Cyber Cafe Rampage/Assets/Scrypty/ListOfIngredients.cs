using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ListOfIngredients : MonoBehaviour {


    public List<string> RecipeList = new List<string>();
    public List<string> ListOfItem = new List<string>();
    [SerializeField]
    public GameObject level;
    // Use this for initialization
    void Start () {
        string _tag = level.tag;

        if (_tag == "Level01")
        {
            RecipeList.Add("Milk");
            RecipeList.Add("Sugar");
            
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

    }

    public void IsCorrest()
    {

        if(RecipeList.SequenceEqual(ListOfItem))
        {
            Debug.Log("JEJ!");
        }

        else
        {
            Debug.Log("O nie!");
        }
    }
}
