using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    [CreateAssetMenu(fileName = "ItemScoreSettingPreset", menuName = "GameDev3/ItemScoreSettingPreset", order = 0)]

    public class ItemScoreSettingPreset : ScriptableObject
    {
        public int ScoreUse;
    }
}