﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour {

    public Inventory inv;
   //string _nazwa;
    
    
	// Use this for initialization
	void Start () {
        //inv = GameObject.Find("GameMaker").GetComponent<Inventory>();
        float x = Random.Range(3,13);
        float y = Random.Range(0, 5);

        if (x > 7)
        {
            x = 6 - x;
        }
        foreach (string nazwa in IVN.ListaPref)
        {
            
            Instantiate(Resources.Load("Prefabs/Ingredients/" + nazwa), new Vector2(x, y), Quaternion.identity);
            Debug.Log("K");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
