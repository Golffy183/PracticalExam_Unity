using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Kowit.GameDevelopment3
{
    public class StartBGSound : MonoBehaviour
    {
        void Start()
        {
            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;
            //Debug.Log(sceneName);
            if (sceneName != "Options")
            {
                ControlBGSound.ChangeScene = true;
            }
        }
    }
}