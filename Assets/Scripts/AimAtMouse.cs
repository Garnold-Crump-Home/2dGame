using UnityEngine;

public class AimAtMouse : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = Camera.main; // cache the main camera
    }

    void Update()
    {
        // Get mouse position in world space
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        // Direction from this object to mouse (ignore Z)
        Vector2 direction = (mousePos - transform.position);

        // Get angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate object to face the cursor
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
