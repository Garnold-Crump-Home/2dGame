using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Player2Controller player2Controller;
    public float player1Point = 0;
    public float player2Point = 0;
    public bool player2ChooseCard;
    public bool player1ChooseCard;
    public float player1Max;
    public float player2Max;
    public Firing firing;
    public FiringController firingC;
    public int randomMapLoader;
    public Slider player1pt;
    public Slider player2pt;
    public GameObject p1win;
    public GameObject p2win;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomMapLoader = Random.Range(2, 7);
        if (player2Controller.playerHealth<= 0)
        {
            player1Point += 0.5f;
            player2Controller.playerHealth = player2Controller.playerMaxHealth;
           
            SceneManager.LoadScene(randomMapLoader);
            if(player1Point == 1)
            {
                player2ChooseCard = true;
                firing.enabled = false;
                
            }
        }

        if (playerMovement.playerHealth <= 0)
        {
            player2Point += 0.5f;
            SceneManager.LoadScene(randomMapLoader);
            playerMovement.playerHealth = playerMovement.playerMaxHealth;
            
             if (player2Point == 1)
            {
                player2Max += 1;
                player1ChooseCard = true;
                firingC.enabled = false;
                player2Point = 0;
            }
        }
        else if (player2Controller.playerHealth <= 0) {
            player2Point += 0.5f;
            SceneManager.LoadScene(randomMapLoader);
            playerMovement.playerHealth = playerMovement.playerMaxHealth;
            player2Controller.playerHealth = player2Controller.playerMaxHealth;
            if (player1Point == 1)
            {
                player1Max += 1;
                player2ChooseCard = true;
                player1Point = 0;
            }
        }

        if (player1ChooseCard)
        {

            SceneManager.LoadScene("Cards");
            player1ChooseCard = false;
            player2Controller.playerHealth = player2Controller.playerMaxHealth;
            playerMovement.playerHealth = playerMovement.playerMaxHealth;
        }
        if (player2ChooseCard) { SceneManager.LoadScene("Cards");
            player2ChooseCard = false;
            player2Controller.playerHealth = player2Controller.playerMaxHealth;
            playerMovement.playerHealth = playerMovement.playerMaxHealth;
        }
        if(player1Point == 5)
        {
            Debug.Log("Player 1 Won");
            p1win.SetActive(true);

        }
        else if  (player2Max == 5)
        {
            Debug.Log("Player 2 Won");

            p2win.SetActive(true);
        }

        player1pt.maxValue = 5;
        player1pt.minValue = 0;
        player1pt.value = player1Point;

        player2pt.maxValue = 5;
        player2pt.minValue = 0;
        player2pt.value = player2Max;
    }
    
}
