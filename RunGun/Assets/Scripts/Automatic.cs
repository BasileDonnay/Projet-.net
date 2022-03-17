using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automatic : MonoBehaviour
{
    private bool fireButtonDown = false;
    public int AutomaticCooldown = 15;
    private int AutomaticCooldownCounter = 1;
    public GameObject bulletPrefab;
    public Transform automaticFirePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckFireAutos();
    }

    void CheckFireAutos()
    {
        if (Input.GetButton("Fire1"))
        {
            fireButtonDown = true;
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

    void ShootAutomatic()
    {
        AutomaticCooldownCounter--;
        if (AutomaticCooldownCounter <= 0)
        {
            AutomaticCooldownCounter = AutomaticCooldown;
            Instantiate(bulletPrefab, automaticFirePoint.position, automaticFirePoint.rotation);
        }
    }

}
