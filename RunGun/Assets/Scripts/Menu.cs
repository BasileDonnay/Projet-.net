using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string niveauACharger;

    public GameObject parametres;

    public void StartGame()
    {
        SceneManager.LoadScene(niveauACharger);
    }

    public void SettingsButton()
    {
        parametres.SetActive(true);
    }

    public void FermerParametres()
    {
        parametres.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
