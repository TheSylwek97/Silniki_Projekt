using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScrypt : MonoBehaviour {

    bool status;
    public int click = 0;
    public GameObject level;
    //List<string> ItemList = new List<string>();
	public void Update () {

        if(level.tag == "Messroom")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.simulated = false;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("OK");
                click = 1;
                
            }
           
        }
        else
        {
            if (status == true)
            {
                Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                transform.position = objPosition;
            }
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
        else
        {
            status = false;
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
