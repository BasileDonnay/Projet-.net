using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audioSource;

    public AudioMixerGroup effetsSonoresMixer;

    public static AudioManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance AudioManager dans la scène");
            return;
        }
        instance = this;
    }

    
    void Start()
    {
        audioSource.clip = playlist[0];
        audioSource.Play();
    }

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
