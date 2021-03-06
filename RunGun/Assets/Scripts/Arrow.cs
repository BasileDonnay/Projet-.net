using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int timeBeforeExplode = 50;
    public int damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

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
            enemy.TakeDamage(Mathf.RoundToInt(damage));
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

    public void IncreaseDamage(int deltaDamage)
    {
        damage = deltaDamage;
    }

    public void IncreaseSpeed(float deltaSpeed)
    {
        speed = deltaSpeed;
    }
}
