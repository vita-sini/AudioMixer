using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void Playback()
    {
        _audioSource.Play();
    }
}
