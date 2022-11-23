using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    [CreateAssetMenu(fileName = "ItemTimeSettingPreset", menuName = "GameDev3/ItemTimeSettingPreset", order = 0)]

    public class ItemTimeSettingPreset : ScriptableObject
    {
        public float TimeUse;
    }
}