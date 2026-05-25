using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadVictory : MonoBehaviour
{
    // Variables
    public float TimeLeft; // the amount of time remaining in the game
    public bool TimerOn = false; // whether the timer is activated
    public string VSname = "VictoryScene"; // the victory scene to be loaded



    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;   // timer is activated
    } // end of start

    // Update is called once per frame
    void Update()
    {
        if(TimerOn) // if timer on(it is)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime; // time left ticks down by the amount of seconds
            }
            else
            {
                Debug.Log("Timer Finished"); // for the console
                TimeLeft = 0; // timer is finished
                TimerOn = false; // deactivated
                SceneManager.LoadScene(VSname); // victory scene is loaded
            }
        }

    } // end of update

 


} // end of class
