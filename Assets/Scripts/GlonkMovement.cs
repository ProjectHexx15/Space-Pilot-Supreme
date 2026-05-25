using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlonkMovement : MonoBehaviour
{
    //Variables
    public float moveSpeed; // movement speed of glonks

    // Start is called before the first frame update
    void Start()
    {

    } // end of start

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0f, 0f); // trnasforms the glonk across the screen at the speed in moveSpeed
    }// End of Update

    private void OnBecameInvisible()// Built in function which checks if GOs have moved off screen/camera
    {
        Destroy(this.gameObject); // destroys glonk if it leaves screen
    }


} // End of Class

