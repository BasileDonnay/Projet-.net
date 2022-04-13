using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRpg : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int shootDelay = 100;
    private int delayCounter;

    // Start is called before the first frame update
    void Start()
    {
        delayCounter = shootDelay;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        delayCounter--;
        if (delayCounter <= 0)
        {
            ShootRpg();
            delayCounter = shootDelay;
        }
    }

    void ShootRpg()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
