using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScrypt : MonoBehaviour
{
    
    bool status;
    public GameObject level;
    //Item item;

    public void Start()
    {
        level = GameObject.Find("Game Master");
       
       // item = gameObject.GetComponent<Item>();
        if (level.tag == "Messroom")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            //rb.constraints = RigidbodyConstraints2D.FreezePosition;
            rb.bodyType = RigidbodyType2D.Kinematic;
        }

        if (level.tag == "Item")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Dynamic;

        }
    }
    public void Update()
    {
        if (status == true)
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "CoffeeMaker")
        {
            Destroy(this.gameObject);
        }
    }


    public void OnMouseDown()
    {
        if ((level.tag != "Messroom") || (level.tag == null))
            status = true;

        if ((level.tag == "Messroom")) 
        {
            // string name = this.gameObject.name;
            //level._item = item;
            // Debug.Log("S");
            // Destroy(this.gameObject);
            IVN.ListaPref.Add(this.gameObject.name);
            Destroy(this.gameObject);
            status = false;
        }
    }

    public void OnMouseUp()
    {
        if (level.tag != "Messroom")
            status = false;

        if (level.tag == "Messroom")
            status = false;
    }

    
}


