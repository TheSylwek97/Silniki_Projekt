using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public void Odbierz(bool jaka)
    {
        if (jaka == true)
        {

            Debug.Log("Działa");
        }

        if(jaka != true)
        {
            Debug.Log("Nie");
        }
    }

}