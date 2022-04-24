using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour
{
    public string fire = "Fire1";
    public int sniperCooldown = 30;
    private int sniperCooldownCounter = 0;
    public GameObject bulletPrefab;
    public Transform sniperFirePoint;
    public AudioClip tirSon; // Cela va permettre de mettre l'effet sonore pour le sniper dans unity

    // Update is called once per frame
    void Update()
    {
        CheckFireSniper();
    }

    void FixedUpdate()
    {
        CalculateSniperCooldown();
    }

    void CalculateSniperCooldown()
    {
        if (sniperCooldownCounter >= 1)
        {
            sniperCooldownCounter++;

            if (sniperCooldownCounter >= sniperCooldown)
            {
                sniperCooldownCounter = 0;
            }
        }
    }

    void CheckFireSniper()
    {
        if (Input.GetButtonDown(fire))
        {
            if (sniperCooldownCounter == 0)
            {
                ShootSniper();
                sniperCooldownCounter = 1;
                AudioManager.instance.PlayClipAt(tirSon, transform.position); /*C'est les caractéristiques que l'effet sonore du Sniper va avoir,
                on a écris la ligne spécifiquement ici afin que le son vient lorsqu'on tire et non avant. le transform.position a pour but que 
                le son du bruit ne soit que auditible là où on est, c'est-à-dire, si un ennemi qui est de l'autre bout de la map tire, on entendra pas le son. */
            }
        }
    }

    void ShootSniper()
    {
        Instantiate(bulletPrefab, sniperFirePoint.position, sniperFirePoint.rotation);
    }
}
