using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D myBody;
    public float torqueForce = 1f;
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myBody.AddTorque(torqueForce);
            Debug.Log("Left arrow");

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myBody.AddTorque(-torqueForce);
            Debug.Log("Right arrow");
        }

    }
}
