using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidDamage : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public GameObject p1;
    public GameObject p2;
    public Player2Controller Player2Controller;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Rigidbody2D rb2 = Player2Controller.GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player1"))
        {
            Rigidbody2D rb = p1.GetComponent<Rigidbody2D>();
            PlayerMovement.playerHealth -= 50;

            rb.velocity = this.transform.up * 10;
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            Player2Controller.playerHealth -= 50;
        }
    }
}
