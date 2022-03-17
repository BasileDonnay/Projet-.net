using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private int gunSelect = 0;
    private bool fireButtonDown = false;
    public int AutomaticCooldown = 15;
    private int AutomaticCooldownCounter = 1;
    private List<string> inventory = new List<string>();
    public int pistolCooldown = 30;
    private int pistolCooldownCounter = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite pistolSprite;
    public Sprite automaticSprite;

    // Start is called before the first frame update
    void Start()
    {
        inventory.Add("Pistol");
    }

    // Update is called once per frame
    void Update()
    {
        GunSelection();
        
        CheckFireSemis();

        ChangeGunSprites();
    }

    void FixedUpdate()
    { 
        CheckFireAutos();

        CalculatePistolCooldown();
    }

    void GunSelection ()
    {
        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") == -1)
        {
            gunSelect++;
            if (gunSelect >= inventory.Count)
            {
                gunSelect = 0;
            }

            fireButtonDown = false;

            ChangeGunSprites();
        }
    }

    void CheckFireSemis()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (inventory[gunSelect] == "Pistol" && pistolCooldownCounter == 0)
            {
                ShootPistol();
                fireButtonDown = false;
                pistolCooldownCounter = 1;
            }
        }
    }

    void ChangeGunSprites()
    {
        if (inventory[gunSelect] == "Pistol")
        {
            spriteRenderer.sprite = pistolSprite;
        }
        if (inventory[gunSelect] == "Automatic")
        {
            spriteRenderer.sprite = automaticSprite;
        }
    }

    void CalculatePistolCooldown ()
    {
        if (pistolCooldownCounter >= 1)
        {
            pistolCooldownCounter++;

            if(pistolCooldownCounter >= pistolCooldown)
            {
                pistolCooldownCounter = 0;
            }
        }
    }

    void CheckFireAutos()
    {
        if (Input.GetButton("Fire1"))
        {
            if (inventory[gunSelect] == "Automatic")
            {
                fireButtonDown = true;
            }
        }
        else
        {
            fireButtonDown = false;
        }

        if (fireButtonDown)
        {
            ShootAutomatic();
        }
    }

    void ShootPistol()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void ShootAutomatic()
    {
        AutomaticCooldownCounter--;
        if (AutomaticCooldownCounter <= 0)
        {
            AutomaticCooldownCounter = AutomaticCooldown;
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }

    public void AddGunToInventory(string gun)
    {
        if (inventory.IndexOf(gun) > 0)
        {
            
        } else
        {
            inventory.Add(gun);
        }
    }
}
