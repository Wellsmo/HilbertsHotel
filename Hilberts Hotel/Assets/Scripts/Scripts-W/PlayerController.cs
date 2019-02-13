using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Public variables
    public float walkSpeed;

    //Private variables
    Rigidbody rb;
    Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    //Non-Physics steps
    void Update()
    {

       //GetType directional input from the user
       float horizontalMovement = Input.GetAxisRaw("Horizontal");
       float verticalMovement = Input.GetAxisRaw("Vertical");


       moveDirection = (horizontalMovement * transform.right + verticalMovement * transform.forward).normalized;
    }

    //Physics steps
    void FixedUpdate()
    {
        //Call the Move function
        Move();
    }

    void Move()
    {

    }
}
