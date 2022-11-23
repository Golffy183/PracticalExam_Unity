using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kowit.GameDevelopment3
{
    public class SoundManager : MonoBehaviour
    {
        [SerializeField] protected SoundSettings m_SoundSettings;

        public Slider m_SliderBGMVolume;
        public Slider m_SliderSFXVolume;

        void Start()
        {
            InitialiseVolumes();
        }
        private void InitialiseVolumes()
        {
            SetBGMVolume(m_SoundSettings.BGMVolume);
            SetSFXVolume(m_SoundSettings.SFXVolume);
        }
        public void SetBGMVolume(float vol)
        {
            m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.BGMVolumeName, vol);
            m_SoundSettings.BGMVolume = vol;
            m_SliderBGMVolume.value = m_SoundSettings.BGMVolume;
        }

        public void SetSFXVolume(float vol)
        {
            m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.SFXVolumeName, vol);
            m_SoundSettings.SFXVolume = vol;
            m_SliderSFXVolume.value = m_SoundSettings.SFXVolume;
        }
    }
}