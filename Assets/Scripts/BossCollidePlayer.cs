using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCollidePlayer : MonoBehaviour
{
    void Start()
    {

    } // end off start

    // Update is called once per frame
    void Update()
    {

    }// end of update function

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") // if the boss collides with the player
        {
            PlayerHealth.Instance.DamagePlayer(); // go to game manager and kill them
            PlayerHealth.Instance.DamagePlayer(); // go to game manager and kill them
            PlayerHealth.Instance.DamagePlayer(); // go to game manager and kill them
            PlayerHealth.Instance.DamagePlayer(); // go to game manager and kill them
            PlayerHealth.Instance.DamagePlayer(); // go to game manager and kill them
            PlayerHealth.Instance.DamagePlayer(); // go to game manager and kill them
            PlayerHealth.Instance.DamagePlayer(); // go to game manager and kill them
            PlayerHealth.Instance.DamagePlayer(); // go to game manager and kill them
            PlayerHealth.Instance.DamagePlayer(); // go to game manager and kill them
            // this kills all player lives if they collide with the boss(inefitient method)
        }
    }// end of player collision 
}
