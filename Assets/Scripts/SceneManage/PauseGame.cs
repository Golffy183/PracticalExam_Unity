using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kowit.GameDevelopment3
{
    public class PauseGame : MonoBehaviour
    {
        public void Pause()
        {
            Time.timeScale = 0f;
        }
        public void Resume()
        {
            Time.timeScale = 1f;
        }
    }
}