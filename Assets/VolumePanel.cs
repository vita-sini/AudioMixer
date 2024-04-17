using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumePanel : MonoBehaviour
{
    private const string TotalVolume = "TotalVolume";
    private const string ButtonVolume = "ButtonVolume";
    private const string BackgroundMusicVolume = "BackgroundMusicVolume";

    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private Slider _sliderTotalVolume;
    [SerializeField] private Slider _sliderButtonVolume;
    [SerializeField] private Slider _sliderBackgroundMusicVolume;

    private float _minValue = 0.0001f;
    private float _maxValue = 1f;

    private float _currentValueSlider;

    private void Awake()
    {
        _sliderTotalVolume.minValue = _minValue;
        _sliderTotalVolume.maxValue = _maxValue;
        _sliderButtonVolume.minValue = _minValue;
        _sliderButtonVolume.maxValue = _maxValue;
        _sliderBackgroundMusicVolume.minValue = _minValue;
        _sliderBackgroundMusicVolume.maxValue = _maxValue;
    }

    public void ChangeTotalVolume()
    {
        _currentValueSlider = _sliderTotalVolume.value;
        _mixer.audioMixer.SetFloat(TotalVolume, Mathf.Log10(_currentValueSlider) * 20);
    }

    public void ChangeButtonVolume()
    {
        _currentValueSlider = _sliderButtonVolume.value;
        _mixer.audioMixer.SetFloat(ButtonVolume, Mathf.Log10(_currentValueSlider) * 20);
    }

    public void ChangeBackgroundMusicVolume()
    {
        _currentValueSlider = _sliderBackgroundMusicVolume.value;
        _mixer.audioMixer.SetFloat(BackgroundMusicVolume, Mathf.Log10(_currentValueSlider) * 20);
    }
}
