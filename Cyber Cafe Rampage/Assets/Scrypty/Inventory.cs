﻿using System.Collections;
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
        /* if (Input.GetMouseButtonDown(0))
         {
             Ray ray = gameObject.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;
             Debug.Log("omo");
             if (Physics.Raycast(ray, out hit))
             {
                 Debug.Log("Yh");
                 if (hit.transform.gameObject.tag == "Item")
                 {

                     Transform selected = hit.transform;
                     ListaItemow.Add(name);
                     Debug.Log("Itemek");
                 }
             }
         }*/

        AddItem();
        /*if ((Input.GetMouseButtonDown(0)) )
        {
            ListaItemow.Add(gameObject);
            Debug.Log("JestSpox");
        }*/
        
    }

    public void AddItem()
    {
        MoveScrypt cs = gameObject.GetComponentInChildren<MoveScrypt>();
        Debug.Log("kiki");
        if (_click == cs.click)
        {
            ListaItemow.Add(cs.name);
            Debug.Log("zostalo dodane");
        }
    }

   /* public void AddList()
    {
        
        if (item.click == true)
        {
            ListaItemow.Add(item.name);
            Debug.Log("zostalo dodane");
        }
    }*/







    /*
     * Ray ray = gameObject.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.Log("Trolor");
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.tag == "Item")
            {
                ListaItemow.Add(gameObject);
                Debug.Log("Itemek");
            }
        }
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * public GameObject level;
    && (this.gameObject.tag == "Messroom"
    [System.Serializable]
    

    public class InventoryData
    {
        public List<Item.ItemData> ListaItemow = new List<Item.ItemData>();
    

    public void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (level.tag == "Messromm")
            {
                Item sItem = gameObject.GetComponent<Item>();
                if (sItem != null)
                {
                    Data.ListaItemow.Add(sItem.Data);
                    Destroy(gameObject);
                }
            }
        }
    }

    public InventoryData Data;

    /* public void OnTriggerEnter(Collider collider)
     {
         if (level.tag == "Messromm") {
             Item sItem = collider.gameObject.GetComponent<Item>();
             if (sItem != null)
             {
                 Data.ListaItemow.Add(sItem.Data);
                 Destroy(collider.gameObject);
             }
         }
     }*/
    /*  public void OnMouseDown()
      {

      }

      private void OnEnable()
      {

      }
    /*  private void OnDisable()
      {

          var value = JsonUtility.ToJson(Data);
          Debug.Log(value);
          File.WriteAllText(Application.persistentDataPath + '/' + "save.dat", value);
      }
      */

}