using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] AudioSource sfxSource;
    public void sound(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
