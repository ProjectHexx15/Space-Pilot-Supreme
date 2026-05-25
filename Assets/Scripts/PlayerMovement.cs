using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables
    public float moveSpeed; // movespeed of the player
    public Rigidbody2D rb2d; // players rigid body component

    public Transform bottomBoundary, topBoundary; // public GO for the screen boundaries

    public Transform LaserFirePoint; // Position for the laser to shoot from
    public GameObject LaserShot; // lazer that will be fired when the player presses down(or clicks?)

    // Start is called before the first frame update
    void Start()
    {

    }// End of Start

    // Update is called once per frame
    void Update()
    {
        // player movement

        rb2d.linearVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;
       

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomBoundary.position.x, topBoundary.position.x), Mathf.Clamp(transform.position.y, bottomBoundary.position.y, topBoundary.position.y), transform.position.z);

        // shoots lazer 
        if (Input.GetButtonDown("Fire1")) // fire1 was changed to spacebar
        {
            Instantiate(LaserShot, LaserFirePoint.position, LaserFirePoint.rotation); // instance of lazer 
        }

    }// End of Update




} // end of class
