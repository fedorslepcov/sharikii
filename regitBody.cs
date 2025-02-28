using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class regitBody : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 250f);
    }
}
