using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Kowit.GameDevelopment3
{
    public class ControlBGSound : MonoBehaviour
    {
        public AudioSource MainMenuBGSound;
        public AudioSource Stage1BGSound;
        public AudioSource Stage2BGSound;

        public static bool ChangeScene;

        void Update()
        {
            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;

            if (ChangeScene)
            {
                CheckSceneChangeBGM(sceneName);
                ChangeScene = false;
            }
        }

        void CheckSceneChangeBGM(string sceneName)
        {
            if (sceneName == "MainMenu")
            {
                if (!MainMenuBGSound.isPlaying)
                {
                    MainMenuBGSound.Play();
                }
                Stage1BGSound.Stop();
                Stage2BGSound.Stop();
            }
            else if (sceneName == "StageSelection")
            {
                if (!MainMenuBGSound.isPlaying)
                {
                    MainMenuBGSound.Play();
                }
                Stage1BGSound.Stop();
                Stage2BGSound.Stop();
            }
            else if (sceneName == "Stage1")
            {
                MainMenuBGSound.Stop();
                if (!Stage1BGSound.isPlaying)
                {
                    Stage1BGSound.Play();
                }
                Stage2BGSound.Stop();
            }
            else if (sceneName == "Stage2")
            {
                MainMenuBGSound.Stop();
                Stage1BGSound.Stop();
                if (!Stage2BGSound.isPlaying)
                {
                    Stage2BGSound.Play();
                }
            }
        }
    }
}