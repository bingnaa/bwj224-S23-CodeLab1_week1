using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public float forceAmount;
    private Rigidbody rb;
    private bool revGravity = false;
    public GameObject spawnB;
    
    public static int score = 0;
    public static int hearts = 3;
    private bool collidedg = false;

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
            rb.AddForce(0, 0, forceAmount);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-forceAmount, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -forceAmount);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(forceAmount, 0, forceAmount);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (revGravity == true)
            {
                revGravity = false;
            }
            else
            {
                revGravity = true;
            }
        }

        if (revGravity)
        {
            rb.AddForce(0, 10, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    { 
        GameObject other = collision.gameObject;
        if (spawnB.GetComponent<spawnBox>().checkListGood(other))
        {
            if (collidedg == false)
            {
                collidedg = true;
                score++;
                Destroy(other);
                Debug.Log(score);
            }
        }
        else if (spawnB.GetComponent<spawnBox>().checkListBad(other))
        {
            hearts--;
            Debug.Log(hearts);
            Destroy(other);
        }
        //time delay code here
        collidedg = false;
    }
}
