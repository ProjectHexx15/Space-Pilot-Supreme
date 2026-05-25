using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBoss : MonoBehaviour
{
    // variables
    private int BossShotCount;
    public int BossShotCountMax;

    // Start is called before the first frame update
    void Start()
    {
        
    } // end of start

    // Update is called once per frame
    void Update()
    {
        
    } // end of update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boss")
        {
            BossShotCount++; // adds to how many times boss is shot
            Destroy(this.gameObject);// Destroys the lazer so it doesnt continue off the screen
            
            
        }
        if(BossShotCount > BossShotCountMax)
        {
            Destroy(other.gameObject); // Destroys the Boss

        } // end off boss trigger collistion



    }



} // end of class
