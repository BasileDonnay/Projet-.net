using UnityEngine;
using UnityEngine.SceneManagement; //Pour pouvoir utiliser le LoadScene après


public class menuGameOver : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("jeu");  //Pour charger la scène Jeu
    }

    public void RetournerM()
    {
        SceneManager.LoadScene("menu");
    }
}

