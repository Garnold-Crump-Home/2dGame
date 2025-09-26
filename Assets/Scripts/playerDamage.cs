using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{
    public bool Homing = false;
    public Transform p2;
    public PlayerMovement playerMovement;
    public Firing firing;
    public Player2Controller player2Controller;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Homing) {
            Vector2 directionToTarget = (p2.position - transform.position).normalized;
            float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.Euler(0, 0, angle);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5 * Time.deltaTime);
            transform.Translate(Vector2.right * 5 * Time.deltaTime);;
        }
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
