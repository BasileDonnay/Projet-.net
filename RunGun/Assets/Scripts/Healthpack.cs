using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthpack : MonoBehaviour
{
    public int healthAmount = 100;
    public AudioClip CoeurSon;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Health health = hitInfo.GetComponent<Health>();
        if (health != null)
        {
            AudioManager.instance.PlayClipAt(CoeurSon, transform.position);
            health.GiveHealth(healthAmount);
            Destroy(gameObject);
        }

    }
}
