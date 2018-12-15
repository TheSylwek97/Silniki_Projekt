using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ListOfIngredients : MonoBehaviour {

    //Recipe01 Recipe;

    public List<string> ListOfItem = new List<string>();
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    public void OnTriggerEnter2D(Collider2D collider)
    {
        string name = collider.gameObject.name;
        ListOfItem.Add(name);
       
    }

    public class IsCorrest
    {
      
    }
}
