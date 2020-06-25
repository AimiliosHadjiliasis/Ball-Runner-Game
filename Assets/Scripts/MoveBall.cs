using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{

    Rigidbody rb; // reference our rigid body
    //add speed and initialite it as public so i can change it unity 
    public float speed = 1.0f;
    public float jumpSpeed = 8.0f; //Add jump speed

    private bool isTuchingGround = true;

    // Start is called before the first frame update
    void Start()
    {
        //Get the rigi d body component
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get movement and store it in variables
        float horizMove = Input.GetAxis("Horizontal");
        float vertMove = Input.GetAxis("Vertical");

        //Move the ball in 3d space
        //At first  create a variable and store the force
        Vector3 ballMovement = new Vector3(horizMove, 0.0f, vertMove);

        //Add forces to the ball based on the user inputs
        rb.AddForce(ballMovement * speed);

        //Make sphere jump
        if ((Input.GetKey(KeyCode.Space)) && isTuchingGround == true)
        {
            Vector3 ballJump = new Vector3(0.0f, 2.0f, 0.0f);
            rb.AddForce(ballJump * jumpSpeed);
        }

        isTuchingGround = false;
    }

    //Use to see if we have a collision between ground and player 
    private void OnCollisionStay()
    {
        isTuchingGround = true;
    }

    //This function checks if our sphere has collide with any object
    private void OnTriggerEnter(Collider other)
    {
        // In our case we need to check if the sphere has collide with the coins
        // so we check if there is a collision between the coins and the sphere
        // by checking if the collider called other which in our case is the coins
        // by checking for their tag name
        // But we need at first tick the trigger in the Unity for the coin prefab
        if (other.gameObject.CompareTag("Coins"))
        {
            //Here we disable the coin in case we colide with it
            other.gameObject.SetActive(false); 
        }
    }
}
