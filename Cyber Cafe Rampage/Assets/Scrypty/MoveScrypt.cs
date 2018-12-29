using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScrypt : MonoBehaviour {

    bool status;
    public int click = 0;
    public GameObject level;
    public void Start()
    {
        if (level.tag == "Messroom")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }
    public void Update ()
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
        {
            status = true;
        }
        if (level.tag == "Messroom")
        {
            click = 1;
        }

    }

    public void OnMouseUp()
    {
        if (level.tag != "Messroom")
        {
            status = false;
        }
        else
        {
            status = false;
        }
    }
}
