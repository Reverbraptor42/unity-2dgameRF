using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;

    public AudioSource completeSource;

    public AudioClip clawCollectSound;

    public AudioClip allClawsCollected;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }

    public void PlayClawCollect()
    {
       audioSource.clip = clawCollectSound;
        audioSource.Play();
    }

    public void PlayClawsCollected()
    {
        completeSource.clip = allClawsCollected;
        completeSource.Play();
    }
}    