using UnityEngine;
using UnityEngine.SceneManagement; //Pour pouvoir utiliser le LoadScene après


public class MenuGameOver : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("jeu");  //Pour charger la scène Jeu
    }

    public void RetournerM(int sceneID)
    {
        SceneManager.LoadScene(sceneID); 
    }
}
