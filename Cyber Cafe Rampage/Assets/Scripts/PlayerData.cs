using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {

    [SerializeField]
    public int levelCount = 0;
    public static int whichLvl;

    private void Update()
    {
        whichLvl = levelCount;
    }
}
