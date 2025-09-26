using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointSystem : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Player2Controller player2Controller;
    public double player1Point= 0;
    public double player2Point= 0;
    public bool player2ChooseCard;
    public bool player1ChooseCard;
    public double player1Max;
    public double player2Max;
    public Firing firing;
    public FiringController firingC;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player2Controller.playerHealth<= 0)
        {
            player1Point += 0.5;
            player2Controller.playerHealth = player2Controller.playerMaxHealth;
           
            SceneManager.LoadScene("Map2");
            if(player1Point == 1)
            {
                player2ChooseCard = true;
                firing.enabled = false;
                
            }
        }

        if (playerMovement.playerHealth <= 0)
        {
            player2Point += 0.5;
            SceneManager.LoadScene("Map2");
            playerMovement.playerHealth = playerMovement.playerMaxHealth;
            if (player1Point == 1)
            {
                player1Max += 1;
                player2ChooseCard=true;
                player1Point = 0;
            }
            if (player2Point == 1) {
                player2Max += 1;
            player1ChooseCard = true;
                firingC.enabled = false;
                player2Point = 0;
            }
        }

        if (player1ChooseCard) {

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
        if(player1Max == 5)
        {
            Debug.Log("Player 1 Won");

        }
        if (player2Max == 5)
        {
            Debug.Log("Player 2 Won");

        }
    }
}
