using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{ 
  
    public PlayerMovement playerMovement;
    public Player2Controller player2Controller;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            player2Controller.playerHealth -= playerMovement.player1DamageAmount;
        }
        if (collision.gameObject.CompareTag("Player1"))
        {
            playerMovement.playerHealth -= playerMovement.player1DamageAmount;
        }
        else { Debug.Log("Not Player"); }
    }
}
