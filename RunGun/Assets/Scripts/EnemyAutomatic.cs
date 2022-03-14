using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAutomatic : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int shootDelay = 100;
    private int delayCounter;
    private int shootAutomatic;
    public int shootAutomaticDelay = 10;
    public int shootAutomaticDuration = 100;

    // Start is called before the first frame update
    void Start()
    {
        delayCounter = shootDelay;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (delayCounter > 0)
        {
            delayCounter--;
        }

        if (delayCounter == 1)
        {
            shootAutomatic = 1;
        }

        if (shootAutomatic >=1)
        {
            shootAutomatic++;
            if(shootAutomatic%shootAutomaticDelay == 0)
            {
                ShootPistol();
            }

            if(shootAutomatic >= shootAutomaticDuration)
            {
                shootAutomatic = 0;
                delayCounter = shootDelay;
            }
        }
    }

    void ShootPistol()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
