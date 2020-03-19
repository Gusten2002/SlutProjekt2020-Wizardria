using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4;//Skapar ett tal som kan ändras i Unity.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        float controlX = Input.GetAxisRaw("Horizontal");
        float controlY = Input.GetAxisRaw("Vertical");
        
        Vector3 movementX = Vector3.right * controlX * Time.deltaTime * speed;//Räknar ut hastigheten åt sidorna
        Vector3 movementY = Vector3.up * controlY * Time.deltaTime * speed * 2;//Räknar ut hastigheten upp och ner.

        

        if (controlX > 0)
        {
            GetComponent<Animator>().SetInteger("xMove", 1);//Om X rörelsen är mer är 0 så ska int:en i animator ändras till 1.

            transform.localScale = new Vector3(0.85f, 0.85f, 1);
        }
        else if (controlX < 0)
        {
            GetComponent<Animator>().SetInteger("xMove", -1);//Däremot om X rörelsen är mindre är 0 så ska int:en i animator ändras till -1.
            
            transform.localScale = new Vector3(-0.85f, 0.85f, 1);//Flippar animationen så att det ser ut som om man går åt vänster.
        } 
        else
        {
            GetComponent<Animator>().SetInteger("xMove", 0);//Annars så ska int:en i animator ändras till 0.
        }

        transform.Translate(movementX + movementY);
    }
}
