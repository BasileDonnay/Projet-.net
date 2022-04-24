using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rpg : MonoBehaviour
{
    public string fire = "Fire1";
    public int rpgCooldown = 30;
    private int rpgCooldownCounter = 0;
    public GameObject bulletPrefab;
    public Transform rpgFirePoint;
    public AudioClip tirSon;

    // Update is called once per frame
    void Update()
    {
        CheckFireRpg();
    }

    void FixedUpdate()
    {
        CalculateRpgCooldown();
    }

    void CalculateRpgCooldown()
    {
        if (rpgCooldownCounter >= 1)
        {
            rpgCooldownCounter++;

            if (rpgCooldownCounter >= rpgCooldown)
            {
                rpgCooldownCounter = 0;
            }
        }
    }

    void CheckFireRpg()
    {
        if (Input.GetButtonDown(fire))
        {
            if (rpgCooldownCounter == 0)
            {
                ShootRpg();
                rpgCooldownCounter = 1;
                AudioManager.instance.PlayClipAt(tirSon, transform.position);
            }
        }
    }

    void ShootRpg()
    {
        Instantiate(bulletPrefab, rpgFirePoint.position, rpgFirePoint.rotation);
    }
}
