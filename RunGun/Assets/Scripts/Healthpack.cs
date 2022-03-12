using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthpack : MonoBehaviour
{
    public int healthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveHealth()
    {

    }

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
