using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Inventory : MonoBehaviour
{
    public List<GameObject> ListaItemow = new List<GameObject>();
    public GameObject movescript;

    public void Start()
    {
        /*if ((Input.GetMouseButtonDown(0)) )
        {
            ListaItemow.Add(gameObject);
            Debug.Log("JestSpox");
        }*/
    }

    public void AddItem(float damage)
    {
        MoveScrypt item = gameObject.GetComponent<MoveScrypt>();
        if(item.click == true)
        {

        }
    }

    private void OnMouseDown()
    {
        Ray ray = gameObject.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.tag == "Item")
            {
                ListaItemow.Add(gameObject); 
            }
        }
    }







    /*public GameObject level;
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