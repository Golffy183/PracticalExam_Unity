using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Kowit.GameDevelopment3
{
    [CreateAssetMenu(menuName = "GameDev3/SoundSettingsPreset", fileName = "SoundSettingsPreset")]

    public class SoundSettings : ScriptableObject
    {
        public AudioMixer AudioMixer;

        [Header("BGMVolume")]
        public string BGMVolumeName = "BGMVolume";
        [Range(-80, 20)]
        public float BGMVolume;

        [Header("SFXVolume")]
        public string SFXVolumeName = "SFXVolume";
        [Range(-80, 20)]
        public float SFXVolume;
    }
}