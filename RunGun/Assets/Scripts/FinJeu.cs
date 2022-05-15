using UnityEngine;
using UnityEngine.SceneManagement; //Pour pouvoir utiliser le LoadScene après

public class FinJeu : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //Rentre en collision avec le drapeau
    {
        if (collision.CompareTag("Player")) //Si c'est le joueur qui rentre en collision
        {
            SceneManager.LoadScene("JeuFin"); //Pour charger la scène de fin de jeu
        }
    }

    public void RetourM(int sceneID) // int car nombre sans virgules
    {
        SceneManager.LoadScene(sceneID); // charge la scène dont on va mettre le numéro
    }
}
