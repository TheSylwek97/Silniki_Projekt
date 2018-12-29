using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Inventory : MonoBehaviour
{
    public List<string> ListaItemow = new List<string>();
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

    private void OnEnable()
    {
        var isom = File.ReadAllText(Application.persistentDataPath + '/' + "save.dat");
        Data = JsonUtility.FromJson<InventoryData>(isom);


    }
    private void OnDisable()
    {

        var value = JsonUtility.ToJson(Data);
        Debug.Log(value);
        File.WriteAllText(Application.persistentDataPath + '/' + "save.dat", value);
    }

}