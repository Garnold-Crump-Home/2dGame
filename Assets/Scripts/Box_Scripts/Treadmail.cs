using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Treadmail : MonoBehaviour
{
    [Header("Treadmill Settings")]
    [Tooltip("Direction and speed of treadmill movement (e.g., (1,0) for right)")]
    public Vector2 treadmillVelocity = new Vector2(2f, 0f);

    [Tooltip("Should the treadmill affect objects with Rigidbody2D?")]
    public bool affectRigidbodies = true;

    [Tooltip("Should the treadmill affect the player even without Rigidbody2D?")]
    public bool affectPlayerTransform = false;

    private void OnCollisionStay2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.attachedRigidbody;

        // Push rigidbodies
        if (affectRigidbodies && rb != null)
        {
            rb.position += treadmillVelocity * Time.fixedDeltaTime;
        }

        // Optional: Move player transform directly (if no rigidbody)
        if (affectPlayerTransform && rb == null && collision.collider.CompareTag("Player"))
        {
            collision.collider.transform.position += (Vector3)(treadmillVelocity * Time.fixedDeltaTime);
        }
    }
}
