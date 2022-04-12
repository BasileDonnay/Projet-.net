using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    private int health;

    public List<GameObject> hearts = new List<GameObject>();
    public GameObject deathEffect;

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

        for (int i = 0; i < hearts.Count; i++)
        {
            if (health <= (100 / hearts.Count) * i)
            {
                hearts[i].SetActive(false);
            }
        }
    }

    public void GiveHealth (int amount)
    {
        health += amount;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        for (int i = 0; i < hearts.Count; i++)
        {
            if (health > (100 / hearts.Count) * i)
            {
                hearts[i].SetActive(true);
            }
        }
    }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
