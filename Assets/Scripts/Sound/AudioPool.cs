using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPool : MonoBehaviour
{
    [SerializeField] private AudioSource audioSourcePrefab;

    public List<AudioSource> AudioSourceList { get; set; }

    [SerializeField] private int audioSourceCount;
    [SerializeField] private int maxCountAudio;

    public static AudioPool Instance { get; set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        AudioSourceList = new List<AudioSource>();
    }

    private void Start()
    {
        CreateAudioSources();
    }

    public void PlayAudio(AudioClip audioClip,float volume=1f)
    {
        if (!CheckListHasAudioMaxCount(audioClip,maxCountAudio))
        {
            AudioSource audioSource = GetEmptyAudioSource();
            audioSource.clip = audioClip;
            audioSource.volume=volume;
            audioSource.Play();
        }
    }

    public void PlayAudioLoop(AudioClip audioClip, float volume = 1f)
    {
        if (!CheckListHasAudioMaxCount(audioClip,1))
        {
            AudioSource audioSource = GetEmptyAudioSource();
            audioSource.clip = audioClip;
            audioSource.loop = true;
            audioSource.volume = volume;
            audioSource.Play();
        }
    }

    private AudioSource GetEmptyAudioSource()
    {
        foreach (AudioSource audioSourceItem in AudioSourceList)
        {
            if (audioSourceItem.clip == null)
                return audioSourceItem;
        }

        AudioSource audioSource = Instantiate(audioSourcePrefab, transform);
        AudioSourceList.Add(audioSource);
        return audioSource;
    }

    private bool CheckListHasAudioMaxCount(AudioClip clip,int maxCount)
    {
        int count = 0;
        foreach (AudioSource audioSource in AudioSourceList)
        {
            if (audioSource.clip == clip)
                count++;

        }

        if (count >= maxCount)
            return true;
        return false;
    }

    private void CreateAudioSources()
    {
        for (int i = 0; i < audioSourceCount; i++)
        {
            AudioSource audioSource = Instantiate(audioSourcePrefab, transform);
            AudioSourceList.Add(audioSource);
        }
    }
}