using UnityEngine;
using UnityEngine.SceneManagement; //Pour pouvoir utiliser le LoadScene apr�s


public class menuGameOver : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("jeu");  //Pour charger la sc�ne Jeu
    }

    public void RetournerM()
    {
        SceneManager.LoadScene("menu");
    }
}

