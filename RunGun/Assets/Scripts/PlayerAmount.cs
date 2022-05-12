using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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


       if(Gamepad.all.Count==1)
        {
           playerAmount+=1;
        }


       //if(playerAmount == 0)
        //{
          //  SceneManager.LoadScene("GameOver");
        //}
    }
}
