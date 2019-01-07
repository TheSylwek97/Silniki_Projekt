using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor.SceneManagement;

public class Inventory : MonoBehaviour
{
    public Item _item;

    [System.Serializable]
    public class InventoryData
    {
        public List<Item.ItemData> ListaItemow = new List<Item.ItemData>();
    }

    private void Update()
    {
        AddItem();
        Debug.Log("K");
    }

    public InventoryData Data;

    public void AddItem()
    {
        Item item = gameObject.GetComponent<Item>();
        Data.ListaItemow.Add(item.Data);
        Debug.Log("O");
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

    /*public List<string> ListaItemow = new List<string>();
    private GameObject _tag;
    public float z = Random.Range(0,10);
    public float x = Random.Range(0, 10);
    GameObject _nazwa;

    private void Start()
    {
        _tag = GameObject.Find("MainCamera");
        EditorSceneManager.sceneLoaded += this.OnLoadCallback;

        /*foreach (string nazwa in ListaItemow)
        {
            Debug.Log("LOL");
            _nazwa = new GameObject(nazwa);
            Instantiate(_nazwa, new Vector2(z, x), Quaternion.identity);
        }
    }

    private void Update()
    {
        if(tag == "Messroom")
        {
           DontDestroyOnLoad(gameObject);
        }

        

    }

    void OnLoadCallback(Scene scene, LoadSceneMode sceneMode)
    {

    }*/
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
