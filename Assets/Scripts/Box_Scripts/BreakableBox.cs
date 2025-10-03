using UnityEngine;

public class BreakableBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile") ||
            collision.gameObject.CompareTag("Projectile2"))
        {
            Destroy(gameObject); 
        }
    }
}
