using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audioSource;

    public AudioMixerGroup effetsSonoresMixer; //dis le mixer

    public static AudioManager instance;

    private void Awake()
    {
        // Permet de montrer qu'il y a deux AudioMixer (sans le principal)
        if(instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance AudioManager dans la scène");
            return;
        }
        instance = this;
    }

    // Lance la musique
    void Start()
    {
        audioSource.clip = playlist[0];
        audioSource.Play();
    }

    /* Le code ci-dessous nous permet que les effets sonores du jeu puissent etre réglé depuis le slider effets sonores et non musique. Si nous avions juste rajoutés
     une AudioSource dans unity, il aurait fallu régler tout le son du jeu avec un seul slider*/
    public AudioSource PlayClipAt(AudioClip clip, Vector3 pos)
    {
        GameObject tempGo = new GameObject("TempAudio");
        tempGo.transform.position = pos;
        AudioSource audioSource = tempGo.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.outputAudioMixerGroup = effetsSonoresMixer;
        audioSource.Play();
        Destroy(tempGo, clip.length);
        return audioSource;

    }

}
