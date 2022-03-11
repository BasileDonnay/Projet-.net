using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int timeBeforeExplode = 500;
    public int damage = 35;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Health enemy = hitInfo.GetComponent<Health>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    void Update()
    {
        timeBeforeExplode--;
        if (timeBeforeExplode < 0)
        {
            Destroy(gameObject);
        }
    }
}
