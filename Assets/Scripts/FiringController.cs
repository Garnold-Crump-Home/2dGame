using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringController : MonoBehaviour
{
    public int projectileSpeed = 10;
    public Transform firePoint;         // The point projectiles spawn from
    public GameObject poop;
    public int ammo = 3;
    public int maxAmmoCapsity = 3;
    public int reloadTime = 4;
    public float fireSpeed = 0.5f;
    private float fireTime;
    private bool wasTriggerPressed = false;

    [Header("Joystick Axes")]
    public string horizontalAxis = "RightStickX_P2";
    public string verticalAxis = "RightStickY_P2";
    public string fireTrigger = "FireRT";

    void Start()
    {
        ammo = maxAmmoCapsity;
        fireTime = fireSpeed;
    }

    void Update()
    {
        fireTime -= Time.deltaTime;

        // Read right stick input
        float stickX = Input.GetAxis(horizontalAxis);
        float stickY = Input.GetAxis(verticalAxis);
        Vector2 aimDir = new Vector2(stickX, stickY);

        // Rotate firePoint toward stick direction if moved enough
        if (aimDir.magnitude > 0.2f)
        {
            float angle = Mathf.Atan2(aimDir.y, aimDir.x) * Mathf.Rad2Deg;
            firePoint.rotation = Quaternion.Euler(0f, 0f, angle);
        }

        // Fire when trigger pressed this frame
        float rightTriggerValue = Input.GetAxisRaw(fireTrigger);
        bool triggerPressed = rightTriggerValue > 0.1f;

        if (ammo > 0 && fireTime <= 0 && triggerPressed && !wasTriggerPressed)
        {
            Shoot();
        }

        wasTriggerPressed = triggerPressed;
    }

    void LateUpdate()
    {
        // Keep firePoint scale positive so flipping player doesn't invert it
        Vector3 fpScale = firePoint.localScale;
        fpScale.x = Mathf.Abs(fpScale.x);
        firePoint.localScale = fpScale;
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(poop, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        // Use firePoint's rotation to move projectile
        rb.velocity = firePoint.right * projectileSpeed; // firePoint.right works because firePoint now rotates to aim

        ammo--;
        fireTime = fireSpeed;

        if (ammo <= 0)
        {
            Invoke("Reload", reloadTime);
        }
    }

    public void Reload()
    {
        ammo = maxAmmoCapsity;
    }
}
