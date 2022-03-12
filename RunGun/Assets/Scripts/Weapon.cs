using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private int maxGunAmount = 2;
    public int gunSelect = 1;
    public bool fireButtonDown = false;
    public int AutomaticCooldown = 100;
    private int AutomaticCooldownCounter;

    // Start is called before the first frame update
    void Start()
    {
        AutomaticCooldownCounter = AutomaticCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        GunSelection();

        CheckShootInputs();
    }

    void GunSelection ()
    {
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") == -1)
        {
            gunSelect++;
            if (gunSelect > maxGunAmount)
            {
                gunSelect = 1;
            }
        }
    }

    void CheckShootInputs()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (gunSelect == 1)
            {
                ShootPistol();
            }
        }

        if (Input.GetButton("Fire1"))
        {
            if (gunSelect == 2)
            {
                fireButtonDown = true;
            }
        }
        else
        {
            fireButtonDown = false;
        }

        if (fireButtonDown)
        {
            ShootAutomatic();
        }
    }

    void ShootPistol()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void ShootAutomatic()
    {
        AutomaticCooldownCounter--;
        if (AutomaticCooldownCounter <= 0)
        {
            AutomaticCooldownCounter = AutomaticCooldown;
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
