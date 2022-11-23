using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    public class KeepSoundSetting : MonoBehaviour
    {
        public SoundSettings soundSettings;

        void Start()
        {
            InitialiseVolumes();
        }
        private void InitialiseVolumes()
        {
            SetBGMVolume(soundSettings.BGMVolume);
            SetSFXVolume(soundSettings.SFXVolume);
        }
        public void SetBGMVolume(float vol)
        {
            soundSettings.AudioMixer.SetFloat(soundSettings.BGMVolumeName, vol);
            soundSettings.BGMVolume = vol;
        }

        public void SetSFXVolume(float vol)
        {
            soundSettings.AudioMixer.SetFloat(soundSettings.SFXVolumeName, vol);
            soundSettings.SFXVolume = vol;
        }
    }
}