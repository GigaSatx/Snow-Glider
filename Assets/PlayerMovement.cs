using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float torque = 3.0f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torque);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torque);
        }
    }
}
