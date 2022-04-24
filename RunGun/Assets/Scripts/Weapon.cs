using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string vertical = "Vertical";
    public List<GameObject> guns = new List<GameObject>();
    private List<string> gunNames = new List<string>() { "Pistol", "Automatic", "Sniper", "Bow", "Rpg"};
    private int gunSelect = 0;
    private List<string> inventory = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        inventory.Add("Pistol");
    }

    // Update is called once per frame
    void Update()
    {
        GunSelection();
    }

    void GunSelection ()
    {
        if (Input.GetButtonDown(vertical) && Input.GetAxisRaw(vertical) == -1)
        {
            gunSelect++;
            if (gunSelect >= inventory.Count)
            {
                gunSelect = 0;
            }

            ChangeActiveGun();
        }
    }

    void ChangeActiveGun()
    {
        for (int i = 0; i < guns.Count; i++)
        {
            if (inventory[gunSelect] == gunNames[i])
            {
                guns[i].SetActive(true);
            }
            else
            {
                guns[i].SetActive(false);
            }
        }
    }

    public void AddGunToInventory(string gun)
    {
        if (inventory.IndexOf(gun) > 0)
        {
            
        } 
        else
        {
            inventory.Add(gun);
        }
    }
}
