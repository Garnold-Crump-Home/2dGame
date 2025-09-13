using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public int projectileSpeed = 1;
    public Transform firePoint;
    public GameObject poop;
    public int ammo = 3;
    public int maxAmmoCapsity = 3;
    public int reloadTime = 4;
    public GameObject player1;
    public float fireSpeed = 1f;
    private float fireTime;

    void Start()
    {
        ammo = maxAmmoCapsity;
        fireTime = fireSpeed;
    }

    void Update()
    {
        fireTime -= Time.deltaTime;

        if (ammo > 0 && fireTime <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(poop, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        // Move projectile in the direction firePoint is facing
        rb.velocity = firePoint.right * projectileSpeed;

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