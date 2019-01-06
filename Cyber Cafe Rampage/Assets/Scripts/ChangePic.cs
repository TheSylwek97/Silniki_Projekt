using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePic : MonoBehaviour {


    [SerializeField]
    public GameObject oldPic, newPic;

    void Start()
    {
        oldPic.GetComponent<GameObject>();
        newPic.GetComponent<GameObject>();
        newPic.gameObject.active = false;
    }
    public void OnMouseDown()
    {
        oldPic.gameObject.active = false;
        newPic.gameObject.active = true;

    }

}
