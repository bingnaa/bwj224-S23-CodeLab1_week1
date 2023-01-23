using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public float forceAmount;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log(message:"W pressed");
            rb.AddForce(0, 0, forceAmount);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log(message:"A pressed");
            rb.AddForce(-forceAmount, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log(message:"S pressed");
            rb.AddForce(0, 0, -forceAmount);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log(message:"D pressed");
            rb.AddForce(forceAmount, 0, forceAmount);
        }
    }
}
