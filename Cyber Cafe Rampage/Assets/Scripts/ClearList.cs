using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearList : MonoBehaviour {

    
	void Update ()
    {
        foreach (string nazwa in IVN.ListaPref)
        {
            IVN.ListaPref.Remove(nazwa);
        }
    }
}
