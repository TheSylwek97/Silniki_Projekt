using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearList : MonoBehaviour {
     
    
    void Update ()
    {
        IVN.ListaPref.Clear();
        Recipe.RecipeList.Clear();
    }
}
