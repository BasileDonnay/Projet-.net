using UnityEngine;
using UnityEngine.SceneManagement; //Pour pouvoir utiliser le LoadScene apr�s


public class MenuGameOver : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("jeu");  //Pour charger la sc�ne Jeu
    }

    public void RetournerM(int sceneID)
    {
        SceneManager.LoadScene(sceneID); 
    }
}
