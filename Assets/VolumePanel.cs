using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumePanel : MonoBehaviour
{
    private const string TotalVolume = "TotalVolume";
    private const string ButtonVolume = "ButtonVolume";
    private const string BackgroundMusicVolume = "BackgroundMusicVolume";

    public AudioMixerGroup Mixer;

    public void ChangeTotalVolume(float volume)
    {
        Mixer.audioMixer.SetFloat(TotalVolume, Mathf.Lerp(-80, 0, volume));
    }

    public void ChangeButtonVolume(float volume)
    {
        Mixer.audioMixer.SetFloat(ButtonVolume, Mathf.Lerp(-80, 0, volume));
    }

    public void ChangeBackgroundMusicVolume(float volume)
    {
        Mixer.audioMixer.SetFloat(BackgroundMusicVolume, Mathf.Lerp(-80, 0, volume));
    }
}
