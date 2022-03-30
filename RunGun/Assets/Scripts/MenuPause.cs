using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField] GameObject menuPause;

    public void Pause()
    {
        menuPause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Reprendre()
    {
        menuPause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RetournerM(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);

    
    }

}
