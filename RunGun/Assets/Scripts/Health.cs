using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    private int health;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    //public GameObject deathEffect;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }

        if (health <= 66)
        {
            heart1.SetActive(false);
        }
        if (health <= 33)
        {
            heart2.SetActive(false);
        }
    }

    public void GiveHealth (int amount)
    {
        health += amount;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        if (health >= 66)
        {
            heart1.SetActive(true);
        }
        if (health >= 33)
        {
            heart2.SetActive(true);
        }
    }

    void Die ()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
