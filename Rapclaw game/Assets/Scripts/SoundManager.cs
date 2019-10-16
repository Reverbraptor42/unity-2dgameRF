using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;

    public AudioSource deathSource;

    public AudioSource completeSource;

    public AudioClip clawCollectSound;

    public AudioClip allClawsCollected;

    public AudioClip hitSound;
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

    public void PlayHitSound()
    {
        deathSource.clip = hitSound;
        deathSource.Play();
    }
}    