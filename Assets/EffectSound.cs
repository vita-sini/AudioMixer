using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSound : MonoBehaviour
{
    [SerializeField] private AudioSource AudioSource;

    public void Playback()
    {
        AudioSource.Play();
    }
}
