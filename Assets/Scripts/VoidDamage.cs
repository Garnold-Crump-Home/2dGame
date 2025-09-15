using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidDamage : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public Player2Controller Player2Controller;
    public int damageAmount = 50;

    private void OnCollisionEnter2D(Collision2D collision)
    {
      

        if (collision.gameObject.CompareTag("Player1"))
        {
            PlayerMovement.playerHealth -= damageAmount;

        }

        if (collision.gameObject.CompareTag("Player2"))
        {
            Player2Controller.playerHealth -= damageAmount;

           
        }
    }
}
