using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGun : MonoBehaviour
{
    public string gunType;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Weapon weapon = hitInfo.GetComponent<Weapon>();
        if (weapon != null)
        {
            weapon.AddGunToInventory(gunType);
            Destroy(gameObject);
        }

    }
}
