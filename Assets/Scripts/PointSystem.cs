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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerMovement.playerHealth <= 0)
        {
            player1Point += 0.5;
            playerMovement.playerHealth = playerMovement.playerMaxHealth;
            SceneManager.LoadScene("Map2");
            if(player1Point == 1)
            {
                player2ChooseCard = true;
            }
        }

        if (player2Controller.playerHealth <= 0)
        {
            player2Point += 0.5;
            SceneManager.LoadScene("Map2");
            player2Controller.playerHealth = player2Controller.playerMaxHealth;
            if(player1Point == 1)
            {
                player1Max += 1;
                player2ChooseCard=true;
            }
            if (player2Point == 1) {
                player2Max += 1;
            player1ChooseCard = true;
            }
        }

        if (player1ChooseCard) {

            SceneManager.LoadScene("Cards");
            player1ChooseCard = false;
        }
        if (player2ChooseCard) { SceneManager.LoadScene("Cards2"); }
    }
}
