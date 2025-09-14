using UnityEngine;

public class AimAtJoystick : MonoBehaviour
{
    [Header("Joystick Axes")]
    public string horizontalAxis = "RightStickX_P2";
    public string verticalAxis = "RightStickY_P2";

    [Header("Deadzone")]
    public float deadZone = 0.2f; // ignore small stick movement

    [Header("Invert Axes")]
    public bool invertX = false;
    public bool invertY = false;

    void Update()
    {
        // Get joystick input
        float x = Input.GetAxis(horizontalAxis);
        float y = Input.GetAxis(verticalAxis);
      

        // Invert axes if needed
        if (invertX) x *= -1f;
        if (invertY) y *= -1f;

        Vector2 stickDirection = new Vector2(x, y);

        // Only rotate if joystick is moved enough
        if (stickDirection.magnitude > deadZone)
        {
            stickDirection.Normalize(); // ensure consistent direction

            // Convert to angle in degrees
            float angle = Mathf.Atan2(stickDirection.y, stickDirection.x) * Mathf.Rad2Deg;

            // Apply rotation on Z only, keep X and Y fixed
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }
}
