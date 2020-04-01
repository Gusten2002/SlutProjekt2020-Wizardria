using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Shoty = Vector3.left * 5 * Time.deltaTime;
        transform.Translate(Shoty);

        if (transform.position.x < -15.25)
        {
            Destroy(this.gameObject);

        }

        if (transform.position.x > 60.25)
        {
            Destroy(this.gameObject);

        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
        
    }
}
