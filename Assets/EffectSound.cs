using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSound : MonoBehaviour
{
    public AudioSource AudioSource;

    public void Playback()
    {
        AudioSource.Play();
    }
}
