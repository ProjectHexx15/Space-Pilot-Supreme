using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance; // ensures there will only be one PlayerHealth script
                                         // and if there was they would all be the same


    // Variables
    public int currentHealth; // current health the player has
    public int maxHealth; //  max health the player is allowed

    public GameObject PlayerDeathEffect; // player death effect game object

    private void Awake() // awake called when a gameobject activates, before start
    {
        Instance = this; // ensures this version of the script is used
    } // end of awake



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        UIManager.Instance.healthBar.maxValue = maxHealth; // goes to the UIManager script for thr healthbar and sets its max to the players max health
        UIManager.Instance.healthBar.value = currentHealth; // goes to the UIManager script for thr healthbar and sets its current value to the players current health
       
    } // End of Start

    public void DamagePlayer() // script to damage the player when colliding
    {
        currentHealth--;
        UIManager.Instance.healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Instantiate(PlayerDeathEffect, transform.position, transform.rotation); // kills player at pos they died at
            gameObject.SetActive(false);

            GameManager.Instance.KillPlayer(); // find the instance of the GameManager script and call the killplayer function
        }

    }// end of damage player function

    public void RespawnPlayer() // funtion to respawn player
    {
        gameObject.SetActive(true);
        currentHealth = maxHealth; // resets player health to max
        UIManager.Instance.healthBar.value = currentHealth; // sets health to current

    } // end of respawn player function

} // End of Class
