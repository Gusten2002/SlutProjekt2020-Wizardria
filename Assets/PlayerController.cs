using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            GetComponent<Animator>().SetInteger("xMove", 1);
        } //Om X rörelsen är mer är 0 så ska int:en i animator ändras till 1.
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            GetComponent<Animator>().SetInteger("xMove", -1);
        } //Däremot om X rörelsen är mindre är 0 så ska int:en i animator ändras till -1.
        else
        {
            GetComponent<Animator>().SetInteger("xMove", 0);
        } //Annars så ska int:en i animator ändras till 0.

    }
}
