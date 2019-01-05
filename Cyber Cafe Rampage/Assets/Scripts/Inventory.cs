using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Inventory : MonoBehaviour
{
    public List<string> ListaItemow = new List<string>();
}

/*
// WERSJA 2 

    [System.Serializable]
    public class InventoryData
    {
        public List<GameObject> ListaItemow = new List<GameObject>();
    }
    

   public InventoryData Data;

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
    */
