/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScrypt : MonoBehaviour
{

    bool status;
    public Inventory level;

    public void Start()
    {
        level = GameObject.Find("GameMaster").GetComponent<Inventory>();

        if (level.tag == "Messroom")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.FreezePosition;

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
        if (level.tag != "Messroom")
            status = true;

        if ((level.tag == "Messroom"))
        {
            level.ListaItemow.Add(this.gameObject);
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
*/
// WERSJA 2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScrypt : MonoBehaviour
{

    bool status;
    public Inventory level;

    public void Start()
    {
        level = GameObject.Find("GameMaster").GetComponent<Inventory>();

        if (level.tag == "Messroom")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.FreezePosition;

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
        if (level.tag != "Messroom")
            status = true;

        if ((level.tag == "Messroom"))
        {
            

            string name = this.gameObject.name;
            level.ListaItemow.Add(name);
            
            Destroy(this.gameObject);
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