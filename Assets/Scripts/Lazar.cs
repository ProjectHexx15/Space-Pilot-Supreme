using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement; // to load differrent scenes and levels

public class Lazar : MonoBehaviour
{
    public static Lazar Instance;


    public float speed;
    public float EnemyCount = 14f;
    public GameObject GlonkExplo;
    public GameObject BossExplo;
    public string VictoryName = "VictoryScene";


    // Start is called before the first frame update
    void Start()
    {
        
    } // End of Start

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed); // sends the lazer across the screen
        
        if (transform.position.x > 9) // 9 is the boundary number for x axis
        {
            Destroy(gameObject); // destorys lazer if it goes out of screen
        }


    } // End of Update

    private void OnTriggerEnter2D(Collider2D other)// change collision to other
    {
        if (other.tag == "GlonkTrooper") // if the trigger is a glonkTrooper tag

        {
            Instantiate(GlonkExplo, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);// Destroys the Glonk
            Destroy(this.gameObject);// Destroys the lazer so it doesnt continue off the screen
            GameManager.Instance.AddScore(10); // Target the GameManager script and pass in a value of 10 to the AddScore function
            // change for glonk adv, boss
            EnemyCount--;
        }

        if (other.tag == "GlonkAdvance") // if the trigger is a glonkadvance tag

        {
            Instantiate(GlonkExplo, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);// Destroys the Glonk
            Destroy(this.gameObject);// Destroys the lazer so it doesnt continue off the screen
            GameManager.Instance.AddScore(15); // Target the GameManager script and pass in a value of 10 to the AddScore function
            // change for glonk adv, boss
            EnemyCount--;
        }

        if (other.tag == "Boss") // if the trigger is a glonkadvance tag

        {
            Instantiate(BossExplo, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);// Destroys the Boss
            Destroy(this.gameObject);// Destroys the lazer so it doesnt continue off the screen
            GameManager.Instance.AddScore(40); // Target the GameManager script and pass in a value of 10 to the AddScore function
            // change for glonk adv, boss
            EnemyCount--;
        }

        if (other.tag == "Shield") // if the trigger is a glonkadvance tag

        {
            Instantiate(GlonkExplo, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);// Destroys the Boss
            Destroy(this.gameObject);// Destroys the lazer so it doesnt continue off the screen
            GameManager.Instance.AddScore(20); // Target the GameManager script and pass in a value of 10 to the AddScore function
            // change for glonk adv, boss
            EnemyCount--;
        }

    } // end off boss trigger collistion

    private void PlayerWin()
    {
        if(EnemyCount == 0)
        {
            UIManager.Instance.victoryScreen.SetActive(true);
        }
    }
   
    




  
    } // End of Class
