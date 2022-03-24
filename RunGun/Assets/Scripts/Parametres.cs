using UnityEngine;
using UnityEngine.Audio;

public class Parametres : MonoBehaviour
{
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