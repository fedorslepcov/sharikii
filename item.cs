using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour

    

{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       rb =  GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "bad")
        {
            Destroy(gameObject);

        }

        if(col.gameObject.tag == "good")
        {
            rb.AddForce(0, 0, 1000f) ;
            print("blabla");
        }   
    }
}
