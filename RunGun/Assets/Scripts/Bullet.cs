using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int timeBeforeExplode = 50;
    public int damage = 35;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        DamageEnemy(hitInfo);

        Destroy(gameObject);
    }

    void DamageEnemy(Collider2D hitInfo)
    {
        Health enemy = hitInfo.GetComponent<Health>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }

    void FixedUpdate()
    {
        timeBeforeExplode--;
        if (timeBeforeExplode < 0)
        {
            Destroy(gameObject);
        }
    }
}
