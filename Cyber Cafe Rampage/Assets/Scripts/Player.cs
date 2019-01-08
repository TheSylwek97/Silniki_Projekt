using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

  

   // public PlayerData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData.whichLvl = PlayerSetttings.LoadData();
    }

    private void OnDisable()
    {
        PlayerSetttings.SaveData(this);
    }
    void Start () {
		
	}
	void Update () {
        Debug.Log(PlayerData.whichLvl);

    }
}
