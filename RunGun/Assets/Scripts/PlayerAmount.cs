using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmount : MonoBehaviour
{
    [Range(1, 4)]
    public int playerAmount = 1;
    public List<GameObject> players = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < players.Count; i++)
        {
            if (playerAmount - 1 == i)
            {
                players[i].SetActive(true);
            }
            else
            {
                players[i].SetActive(false);
            }
        }
    }
}
