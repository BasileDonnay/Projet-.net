using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int coinsCount;

    public static Inventory instance;

    private void Awake()
    {

if(instance != null)
{

    Debug.LogWarning("top d'instace de Inventory dans la scene");
    return;
}
        instance = this;
    }


public void AddCoins (int count){
    coinsCount += count;
}

}
