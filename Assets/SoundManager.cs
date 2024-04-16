using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    private const string TotalVolume = "TotalVolume";

    [SerializeField] private AudioMixerGroup Mixer;

    [SerializeField] private Sprite onMusic;
    [SerializeField] private Sprite offMusic;

    [SerializeField] private Image MusicButton;

    private bool isMusicEnable;

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
        Mixer.audioMixer.SetFloat(TotalVolume, 0);
        MusicButton.GetComponent<Image>().sprite = onMusic;
        isMusicEnable = true;
    }
    private void DisableMusic()
    {
        Mixer.audioMixer.SetFloat(TotalVolume, -80);
        MusicButton.GetComponent<Image>().sprite = offMusic;
        isMusicEnable = false;
    }
}
