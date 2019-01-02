using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScrypt : MonoBehaviour {

    bool status;
    public bool click;
    public bool mom;
    public bool hover = false;
    public GameObject level;
   // public GameObject item;
    //private Transform playerSelection;
   // private bool isSelected;

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
        if ((hover == true) && (Input.GetMouseButtonDown(0)))
        {
           // click = true;
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
        if ((level.tag == "Messroom"))
        {
           
            
            
        }
        else
        {
            
        }
    }

    public void OnMouseDrag()
    {
        
    }

    
    
    public void OnMouseUp()
    {
        if (level.tag != "Messroom")
        {
            status = false;
        }
        if (level.tag == "Messroom")
        {
            status = false;
        }
        if(tag == "Item")
        {
            this.gameObject.SetActive(true);
        }
        if(tag != "Item")
        {
            this.gameObject.
        }
    }

    public void OnMouseOver()
    {
        tag = "Item";
    }

    public void OnMouseExit()
    {
        tag = "Untagged";
    }

    /* public void IsClick(bool mom)
     {
         if(mom == true)
         {
             click = true;
             Debug.Log("Zorro");
         }
     }*/

    /*public void OnMouseOver(GameObject newParent)
    {
        hover = true;
        //newParent = gameObject.transform;
        // level.transform.SetChot(newParent.transform);
        item.transform.parent = newParent.transform;
        
    }*/

    /* public void selectPlayer()
     {
         isSelected = true;
         playerSelection.gameObject.SetActive(true);
     }

     public void unselectPlayer()
     {
         isSelected = false;
         playerSelection.gameObject.SetActive(false);
     }*/

}
