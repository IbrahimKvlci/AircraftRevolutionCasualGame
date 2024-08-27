using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [field: SerializeField] public AudioSO AudioSO { get; set; }

    public static SoundManager Instance { get; set; }

    private void Awake()
    {
        Instance = this;
    }


    public void PlayAudio(AudioClip audioClip, Vector3 position, float volume = 1f)
    {
        if (audioClip != null)
            AudioSource.PlayClipAtPoint(audioClip, position, volume);
    }

    public void PlayAudioOnCamera(AudioClip audioClip, float volume = 1f)
    {
        if (audioClip != null)
            AudioSource.PlayClipAtPoint(audioClip, Camera.main.transform.position, volume);
    }

    public void PlayAudioNormalized(AudioClip audioClip, Vector3 position, float volume = 1f)
    {
        Vector3 pos = position - Camera.main.transform.position;
        pos.Normalize();

        if (audioClip != null)
            AudioSource.PlayClipAtPoint(audioClip, pos + Camera.main.transform.position, volume);
    }

    public void PlayAudioFromPool(AudioClip audioClip, float volume = 1f)
    {
        if (audioClip != null)
            AudioPool.Instance.PlayAudio(audioClip,volume);
    }
    public void PlayAudioLoopFromPool(AudioClip audioClip, float volume = 1f)
    {
        if (audioClip != null)
            AudioPool.Instance.PlayAudioLoop(audioClip,volume);
    }

    public IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }

    public void StopAllSoundsInPool()
    {
        AudioPool.Instance.StopAllSounds();
    }

}