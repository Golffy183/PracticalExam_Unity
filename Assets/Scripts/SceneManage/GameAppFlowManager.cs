using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Kowit.GameDevelopment3
{
    public class GameAppFlowManager : MonoBehaviour
    {
        protected static bool IsSceneOptionsLoaded;

        public void LoadScene(string sceneName)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }

        public void UnloadScene(string sceneName)
        {
            SceneManager.UnloadSceneAsync(sceneName);
        }

        public void LoadSceneAdditive(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        }

        public void LoadOptionsScene(string optionSceneName)
        {
            if (!IsSceneOptionsLoaded)
            {
                SceneManager.LoadScene(optionSceneName, LoadSceneMode.Additive);
                IsSceneOptionsLoaded = true;
            }
        }

        public void UnloadOptionsScene(string optionSceneName)
        {
            if (IsSceneOptionsLoaded)
            {
                SceneManager.UnloadSceneAsync(optionSceneName);
                IsSceneOptionsLoaded = false;
            }
        }

        public void ExitGame()
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }

        public void TryAgain()
        {
            Time.timeScale = 1;

            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;

            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }



        #region Scene Load and Unload Events Handler
        private void OnEnable()
        {
            SceneManager.sceneUnloaded += SceneUnloadEventHandler;
            SceneManager.sceneLoaded += SceneLoadedEventHandler;
        }

        private void OnDisable()
        {
            SceneManager.sceneUnloaded -= SceneUnloadEventHandler;
            SceneManager.sceneLoaded -= SceneLoadedEventHandler;
        }

        private void SceneUnloadEventHandler(Scene scene)
        {

        }
        private void SceneLoadedEventHandler(Scene scene, LoadSceneMode mode)
        {
            //If the loaded scene is not the SceneOptions, set flag IsOptionsLoaded to
            //false
            if (scene.name.CompareTo("Options") != 0)
            {
                IsSceneOptionsLoaded = false;
            }
        }
    }
    #endregion
}