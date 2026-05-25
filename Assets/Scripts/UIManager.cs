using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // to load differrent scenes and levels
using UnityEngine.UI; // References the Unity UI Library 

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject gameOverScreen; // references gameoverscreen GO
    public GameObject victoryScreen; // references VictoryScreen GO

    public Text livesText; // Creates a reference to the text object which holds the score

    public Slider healthBar;
    public Text scoreText;

    public string mainMenuName = "MainMenu";

    private void Awake()
    {
        Instance = this;

    }// end of Awake function


    // Start is called before the first frame update
    void Start()
    {

    }// end of start

    // Update is called once per frame
    void Update()
    {

    }// end of update

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads and restarts the level

    }// end of Restart Function

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(mainMenuName); // loads the mainmenu scene


    }// end of quit function

} // End of Class
