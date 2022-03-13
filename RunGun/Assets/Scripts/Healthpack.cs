using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthpack : MonoBehaviour
{
    public int healthAmount = 100;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Health health = hitInfo.GetComponent<Health>();
        if (health != null)
        {
            health.GiveHealth(healthAmount);
            Destroy(gameObject);
        }

    }
}
