using UnityEngine;
using UnityEngine.SceneManagement;

public class menuGameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public string niveauACharger;

    private void OnEnable()
    {
        Health.MortPerso += AfficheMenuGO;
    }

    private void OnDisable()
    {
        Health.MortPerso -= AfficheMenuGO;
    }
   
    public void AfficheMenuGO()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f; // permet que lorsqu'on appuie sur pause, le jeu s'arrete aussi et ne continue pas
    }

    public void RecommencerJeu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(niveauACharger);
    }

    public void RetournerM(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
