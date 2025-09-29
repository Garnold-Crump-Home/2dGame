using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Damage : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Player2Controller player2Controller;
    public Transform p1;
    public bool Homing = false;
    public LineRenderer lineRenderer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Homing)
        {
            if (Homing)
            {
                if (Homing)
                {
                    Vector2 directionToTarget = (p1.position - transform.position).normalized;

                    // Update line renderer
                    lineRenderer.SetPosition(0, transform.position);
                    lineRenderer.SetPosition(1, p1.position);

                    float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;
                    Quaternion targetRotation = Quaternion.Euler(0, 0, angle);
                    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5 * Time.deltaTime);
                    transform.Translate(Vector2.right * 5 * Time.deltaTime);
                }

            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            player2Controller.playerHealth -= player2Controller.player2Damage;
        }
        if (collision.gameObject.CompareTag("Player1"))
        {
            playerMovement.playerHealth -= player2Controller.player2Damage;
        }
        else { Debug.Log("Not Player"); }
    }
}
