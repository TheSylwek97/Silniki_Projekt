using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Inventory : MonoBehaviour
{
    public List<string> ListaItemow = new List<string>();
    //public int _click = 1;
    //public GameObject item;
    //private GameController gc;
    public bool isClick;

    public void Start()
    {
        //gc = GameObject.Find("GameController").GetComponent<GameController>();
    }

    public void Update()
    {

        AddItem();
    }

    public void AddItem()
    {
        MoveScrypt cs = gameObject.GetComponentInChildren<MoveScrypt>();
        if (cs.tag == "Item")
        {
            ListaItemow.Add(cs.name);
            Debug.Log("zostalo dodane");
            Destroy(cs.gameObject);
        }
    }

    /*public void Tom(bool click)
    {
        if (click = true)
        {
            isClick = true;
        }
    
    }*/

    public void SetParent()
    {
        //item.transform.SetParent(newParent);
        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = gameObject.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Player")
                {
                    Transform selected = hit.transform;
                    gc.unselectAll();
                    selected.SendMessage("selectPlayer");
                }
            }
        }*/
    }

    /*private void OnEnable()
    {
        var isom = File.ReadAllText(Application.persistentDataPath + '/' + "save.dat");
        Data = JsonUtility.FromJson<InventoryData>(isom);


    }
    private void OnDisable()
    {

        var value = JsonUtility.ToJson(Data);
        Debug.Log(value);
        File.WriteAllText(Application.persistentDataPath + '/' + "save.dat", value);
    }*/

    

}