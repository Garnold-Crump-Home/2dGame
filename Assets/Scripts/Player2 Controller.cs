using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Controller : MonoBehaviour
{
    public int playerHealth = 100;
    public int playerMaxHealth = 100;
    public int player2Damage = 25;
    public int bulletSize2 = 1;
    public Slider slider;
    public bool IncreaseSize;
    public Transform projectile2;
    public FiringController firingController;

    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    [Header("Ground Check")]
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    private float moveInput;

    private SpriteRenderer spriteRenderer;

    // Keep track of last facing direction: 1 = right, -1 = left
    private float lastFacingDir = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (IncreaseSize)
        {

            projectile2.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            int i = firingController.projectileSpeed * 2 / 10;
            firingController.projectileSpeed -= i;



            IncreaseSize = false;
        }
        slider.minValue = 0;
        slider.maxValue = playerMaxHealth;
        slider.value = playerHealth;
        // Get movement input
        moveInput = Input.GetAxisRaw("Horizontal_P2");

        // Jump
        if (Input.GetButtonDown("Jump_P2") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Get right stick input for aiming
        float rightStickX = Input.GetAxis("RightStickX_P2");
        float rightStickY = Input.GetAxis("RightStickY_P2");
        Vector2 rightStickDir = new Vector2(rightStickX, rightStickY);

        // Determine facing direction
        if (rightStickDir.magnitude > 0.2f)
        {
            // If aiming, face right stick direction
            lastFacingDir = rightStickDir.x >= 0 ? 1f : -1f;
        }
        else if (moveInput != 0)
        {
            // If not aiming, face movement direction
            lastFacingDir = moveInput > 0 ? 1f : -1f;
        }

        // Apply facing
        transform.localScale = new Vector3(
            Mathf.Abs(transform.localScale.x) * lastFacingDir,
            transform.localScale.y,
            transform.localScale.z
        );
    }

    void FixedUpdate()
    {
        // Move player with left stick
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Ground check
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
}
