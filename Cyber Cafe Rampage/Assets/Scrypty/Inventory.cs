using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Inventory : MonoBehaviour
{
    public List<string> ListaItemow = new List<string>();
    //public GameObject movescript;
    public int _click = 1;

    public void Update()
    {
        AddItem();
    }

    public void AddItem()
    {
        MoveScrypt cs = gameObject.GetComponentInChildren<MoveScrypt>();
        if (_click == cs.click)
        {
            ListaItemow.Add(cs.name);
            Debug.Log("zostalo dodane");
            Destroy(cs.gameObject);
        }
    }
}