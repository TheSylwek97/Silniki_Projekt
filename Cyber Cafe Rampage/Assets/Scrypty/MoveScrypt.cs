using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScrypt : MonoBehaviour {

    bool status;
    public GameObject level;
	void Update () {

        if(status == true)
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y); //pobieramy sobie pozycję myszki
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); //musi to być, żeby działało, bo Unity. Przynajmniej tak zrozumiałam
            transform.position = objPosition; //rusza się
                                              // GetComponent<Rigidbody2D>().simulated = true; //dajemy simulated na true, żeby znikał nam obiekt, jeżeli cały czas bedzie true to spadnie ze sceny

        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "CoffeeMaker") //A tutaj gdy najezdrzamy na obiekt "ekspress" to obiekt znika ze sceny
        {
            Destroy(this.gameObject);
        }
    }//niszczenie obiektu po najechaniu


    public void OnMouseDown()
    {
        if (level.tag != "Messroom")
        {
            status = true;
        }
    }

    public void OnMouseUp()
    {
        if (level.tag != "Messroom")
        {
            status = false;
        }
    }
}
