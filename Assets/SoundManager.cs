using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    private const string BackgroundMusicVolume = "BackgroundMusicVolume";

    public AudioMixerGroup Mixer;

    public Sprite onMusic;
    public Sprite offMusic;

    public Image MusicButton;

    public bool isMusicEnable;

    private void Awake()
    {
        EnableMusic();
    }

    public void ToggleMusic()
    {
        if (isMusicEnable == false)
        {
            EnableMusic();
        }
        else
        {
            DisableMusic();
        }
    }

    private void EnableMusic()
    {
        Mixer.audioMixer.SetFloat(BackgroundMusicVolume, 0);
        MusicButton.GetComponent<Image>().sprite = onMusic;
        isMusicEnable = true;
    }
    private void DisableMusic()
    {
        Mixer.audioMixer.SetFloat(BackgroundMusicVolume, -80);
        MusicButton.GetComponent<Image>().sprite = offMusic;
        isMusicEnable = false;
    }
}
