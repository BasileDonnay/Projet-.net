using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour
{
    public string fire = "Fire1";
    public int sniperCooldown = 30;
    private int sniperCooldownCounter = 0;
    public GameObject bulletPrefab;
    public Transform sniperFirePoint;

    // Update is called once per frame
    void Update()
    {
        CheckFireSniper();
    }

    void FixedUpdate()
    {
        CalculateSniperCooldown();
    }

    void CalculateSniperCooldown()
    {
        if (sniperCooldownCounter >= 1)
        {
            sniperCooldownCounter++;

            if (sniperCooldownCounter >= sniperCooldown)
            {
                sniperCooldownCounter = 0;
            }
        }
    }

    void CheckFireSniper()
    {
        if (Input.GetButtonDown(fire))
        {
            if (sniperCooldownCounter == 0)
            {
                ShootSniper();
                sniperCooldownCounter = 1;
            }
        }
    }

    void ShootSniper()
    {
        Instantiate(bulletPrefab, sniperFirePoint.position, sniperFirePoint.rotation);
    }
}
