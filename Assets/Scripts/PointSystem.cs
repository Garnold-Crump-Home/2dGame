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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerMovement.playerHealth <= 0)
        {
            player1Point = 0.5;
            playerMovement.playerHealth = playerMovement.playerMaxHealth;
            SceneManager.LoadScene("Map2");
        }

        if (player2Controller.playerHealth <= 0)
        {
            player2Point = 0.5;
            SceneManager.LoadScene("Map2");
            player2Controller.playerHealth = player2Controller.playerMaxHealth;
        }
    }
}
