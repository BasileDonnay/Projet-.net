using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField] GameObject menuPause;

    public void Pause()
    {
        menuPause.SetActive(true);
        Time.timeScale = 0f; // permet que lorsqu'on appuie sur pause, le jeu s'arrete aussi et ne continue pas
    }

    public void Reprendre()
    {
        menuPause.SetActive(false);
        Time.timeScale = 1f; //le jeu reprend
    }

    public void RetournerM(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

}
