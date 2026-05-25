using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollideGlonk : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }// end of update function

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") // if the Glonk collides with the player
        {
            PlayerHealth.Instance.DamagePlayer(); // go to player health and damage them
        }
    }// end of player collision 





} // End of Class
