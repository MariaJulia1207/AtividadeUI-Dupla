using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public float volume = 1.0f;
    public bool loop = false;
    public bool playOnAwake = false;
    public float pitch = 1.0f;
    public float panStereo = 0.0f;
    public float spatialBlend = 0.0f;
    public float reverbZoneMix = 1.0f;
    public float dopplerLevel = 1.0f;
    public float spread = 0.0f;
    public float minDistance = 1.0f;
    public float maxDistance = 500.0f;
    public AudioRolloffMode rolloffMode = AudioRolloffMode.Logarithmic;
    // O código deve ser ativado ao clicar em qualquer botão na tela
    public void Play(){
        
        audioSource.PlayOneShot(audioClip);
        audioSource.PlayOneShot(audioClip, volume);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.AddComponent<audioSource>();
        audioSource.clip = audioClip;
        audioSource.volume = volume;
        audioSource.loop = loop;
        audioSource.playOnAwake = playOnAwake;
        audioSource.pitch = pitch;
        audioSource.panStereo = panStereo;
        audioSource.spatialBlend = spatialBlend;
        audioSource.reverbZoneMix = reverbZoneMix;
        audioSource.dopplerLevel = dopplerLevel;
        audioSource.spread = spread;
        audioSource.minDistance = minDistance;
        audioSource.maxDistance = maxDistance;
        audioSource.rolloffMode = rolloffMode;
        audioSource.clip = audioClip;
        audioSource.mute = true;
        audioSource.bypassEffects = true;
        audioSource.Play();
        audioSource.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        // O código deve ser ativado ao clicar em q1uarquer botão na tela
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
        }
        if (Input.GetMouseButtonDown(1))
        {
            audioSource.Stop();
        }
        
    }
}