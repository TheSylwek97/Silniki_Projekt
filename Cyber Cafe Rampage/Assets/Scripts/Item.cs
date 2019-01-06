using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    
    [System.Serializable]
    public class ItemData
    {
        public string Name;
    }

    public ItemData Data;
}