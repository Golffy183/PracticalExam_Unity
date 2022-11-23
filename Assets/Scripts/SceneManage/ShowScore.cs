using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Kowit.GameDevelopment3
{
    public class ShowScore : MonoBehaviour
    {
        [SerializeField] protected TextMeshProUGUI ScoreText;

        void Update()
        {
            ScoreText.text = "Score : " + ScoreGame.Score.ToString();
        }
    }
}