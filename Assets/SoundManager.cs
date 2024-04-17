using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    private const string TotalVolume = "TotalVolume";

    [SerializeField] private AudioMixerGroup _mixer;

    [SerializeField] private Sprite _onMusic;
    [SerializeField] private Sprite _offMusic;

    [SerializeField] private Image _musicButton;

    private bool _isMusicEnable;

    private void Awake()
    {
        EnableMusic();
    }

    public void ToggleMusic()
    {
        if (_isMusicEnable == false)
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
        _mixer.audioMixer.SetFloat(TotalVolume, 0);
        _musicButton.sprite = _onMusic;
        _isMusicEnable = true;
    }
    private void DisableMusic()
    {
        _mixer.audioMixer.SetFloat(TotalVolume, -80);
        _musicButton.sprite = _offMusic;
        _isMusicEnable = false;
    }
}
