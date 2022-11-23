using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Kowit.GameDevelopment3
{
    public class ScoreGame : MonoBehaviour
    {
        public static int Score;
        [HideInInspector]
        public int m_Score = 0;
        [SerializeField] protected TextMeshProUGUI ScoreText;

        private void Update()
        {
            ScoreText.text = "Score : " + m_Score.ToString();
        }

        public void EndStage()
        {
            Score = m_Score;
        }
    }
}