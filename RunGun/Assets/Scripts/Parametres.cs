using UnityEngine;
using UnityEngine.Audio;

public class Parametres : MonoBehaviour
{
    [SerializeField] GameObject ParametresJeu;

    public void PauseParametres()
    {
        ParametresJeu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Reprendre()
    {
        ParametresJeu.SetActive(false);
        Time.timeScale = 1f;
    }

    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Musique", volume);
    }

    public void SetSound(float volume)
    {
        audioMixer.SetFloat("Effets sonores", volume);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}