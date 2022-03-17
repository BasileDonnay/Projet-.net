using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public int pistolCooldown = 30;
    private int pistolCooldownCounter = 0;
    public GameObject bulletPrefab;
    public Transform pistolFirePoint;

    // Update is called once per frame
    void Update()
    {
        CheckFirePistol();
    }

    void FixedUpdate()
    {
        CalculatePistolCooldown();
    }

    void CalculatePistolCooldown()
    {
        if (pistolCooldownCounter >= 1)
        {
            pistolCooldownCounter++;

            if (pistolCooldownCounter >= pistolCooldown)
            {
                pistolCooldownCounter = 0;
            }
        }
    }

    void CheckFirePistol()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (pistolCooldownCounter == 0)
            {
                ShootPistol();
                pistolCooldownCounter = 1;
            }
        }
    }

    void ShootPistol()
    {
        Instantiate(bulletPrefab, pistolFirePoint.position, pistolFirePoint.rotation);
    }
}
