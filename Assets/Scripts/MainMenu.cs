using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Variables
    public string loadLevel1;
    public string mainMenuName = "MainMenu";

    // Start is called before the first frame update
    void Start()
    {

    } // end of start

    // Update is called once per frame
    void Update()
    {

    } // end of update

    public void StartGame()
    {
        SceneManager.LoadScene(loadLevel1); // loads level1

    }// end of start game function

    public void QuitGame()
    {
        Application.Quit(); // Exits the game in build mode only

    }// end of quit game function

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(mainMenuName); // loads the mainmenu scene


    }// end of quit function
}
