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
    public Transform player;
    public LineRenderer lineRenderer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Homing)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);
            if (distanceToPlayer < 15f) {
                Vector2 directionToTarget = (p2.position - transform.position).normalized;

                // Only draw the line if the object is close to the player
               // player = your player transform
                if (distanceToPlayer < 8f) // adjust 5f to your desired proximity
                {
                    lineRenderer.SetPosition(0, transform.position);
                    lineRenderer.SetPosition(1, p2.position);
                }

                // Rotate towards target
                float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;
                Quaternion targetRotation = Quaternion.Euler(0, 0, angle);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, firing.projectileSpeed * Time.deltaTime);

                // Move forward
                transform.Translate(Vector2.right * firing.projectileSpeed * Time.deltaTime); }
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
