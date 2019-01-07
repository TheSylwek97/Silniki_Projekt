using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePic : MonoBehaviour {


    [SerializeField]
    public GameObject oldPic, newPic;
    public GameObject fire, steam;

    void Start()
    {
        oldPic.GetComponent<GameObject>();
        newPic.GetComponent<GameObject>();
        fire.GetComponent<GameObject>();
        steam.GetComponent<GameObject>();
        newPic.gameObject.active = false;
        fire.gameObject.active = false;
        steam.gameObject.active = false;

    }
    public void OnMouseDown()
    {
        oldPic.gameObject.active = false;
        newPic.gameObject.active = true;
        fire.gameObject.active = true;
        steam.gameObject.active = true;

    }

}
