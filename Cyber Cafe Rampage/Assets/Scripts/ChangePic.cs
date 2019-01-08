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
        newPic.gameObject.SetActive(false);
        fire.gameObject.SetActive(false);
        steam.gameObject.SetActive(false);

    }
    public void OnMouseDown()
    {
        oldPic.gameObject.SetActive(false);
        newPic.gameObject.SetActive(true);
        fire.gameObject.SetActive(true);
        steam.gameObject.SetActive(true);

    }

}
