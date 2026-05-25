using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // public instance of the script

    public int currentLives = 3; // players current health is set to max, will go down when collide

    public float playerRespawnTime = 2f; // the time it takes for player to respawn

    public int currentScore; // stores the players current score

    private void Awake()
    {
        Instance = this;

    }//end of awake function

    public void KillPlayer()
    {
        currentLives--; // losing a life
        UIManager.Instance.livesText.text = "x " + currentLives; // changes the lives display on the UI

        if (currentLives > 0)
        {
           
            StartCoroutine(RespawnPlayerCor());
        } // corutine to respawnplayer
        else
        {
            // game over code
            UIManager.Instance.gameOverScreen.SetActive(true); // Display the Game Over Screen
           
        }

    }// end of kill player function

    // Start is called before the first frame update
    void Start()
    {
        UIManager.Instance.livesText.text = "x " + currentLives; // updates lives display
        UIManager.Instance.scoreText.text = "score " + currentScore;  // updates score display
    } // end of start

    // Update is called once per frame
    void Update()
    {

    }// end of update

    public IEnumerator RespawnPlayerCor()
    {
        yield return new WaitForSeconds(playerRespawnTime); // Tell Unity to wait a set amount of time before repawning the player GO 
        PlayerHealth.Instance.RespawnPlayer(); // Target the PlayerHealth script instance and run the respanwPlayer function
    }

    public void AddScore(int scoreToAdd) // Every time we call AddScore it will pass in an int variable value called scoreToAdd
    {
        currentScore += scoreToAdd; // instead of 10 it will pickup whichever value is set based on the enemy destroyed(glonk adv, boss)
        UIManager.Instance.scoreText.text = "score: " + currentScore;

    }// end of add score function

  
     


  


}
